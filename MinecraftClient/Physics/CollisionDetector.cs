using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MinecraftClient.Mapping;

namespace MinecraftClient.Physics
{
    /// <summary>
    /// Performs AABB collision detection against the block world.
    /// Mirrors Entity.collide(), collideBoundingBox(), collideWithShapes() from vanilla MC.
    /// </summary>
    public static class CollisionDetector
    {
        // Pre-allocated axis order arrays to avoid allocating int[] on every call.
        private static readonly int[] AxisOrder_YZX = [1, 2, 0];
        private static readonly int[] AxisOrder_YXZ = [1, 0, 2];
        private static readonly int[] AxisOrder_XYZ = [0, 1, 2];
        private static readonly int[] AxisOrder_ZYX = [2, 1, 0];

        // Thread-local reusable buffers for collision detection to avoid per-call allocations.
        // Safe because physics runs on a single thread per client.
        [ThreadStatic] private static List<Aabb>? t_colliderBuf;
        [ThreadStatic] private static List<Aabb>? t_stepColliderBuf;
        [ThreadStatic] private static List<float>? t_heightBuf;
        /// <summary>
        /// Resolve movement with full collision detection including step-up.
        /// This is the main entry point, equivalent to Entity.collide(Vec3).
        /// </summary>
        public static Vec3d Collide(World world, Aabb entityBox, Vec3d movement, bool onGround, float maxUpStep)
        {
            if (movement.LengthSqr() == 0.0)
                return movement;

            // Collect block collision shapes in the movement path (reuses thread-local buffer)
            var colliders = t_colliderBuf ??= new List<Aabb>(64);
            colliders.Clear();
            CollectBlockColliders(world, entityBox.ExpandTowards(movement), colliders);
            Vec3d resolved = CollideWithShapes(movement, entityBox, colliders);

            bool blockedX = movement.X != resolved.X;
            bool blockedZ = movement.Z != resolved.Z;
            bool blockedY = movement.Y != resolved.Y;
            bool hitGroundDuringMove = blockedY && movement.Y < 0.0;

            // Step-up logic: if blocked horizontally and on ground or just landed
            if (maxUpStep > 0.0f && (hitGroundDuringMove || onGround) && (blockedX || blockedZ))
            {
                // Try stepping up
                Aabb stepBase = hitGroundDuringMove ? entityBox.Move(0, resolved.Y, 0) : entityBox;
                Aabb expanded = stepBase.ExpandTowards(movement.X, maxUpStep, movement.Z)
                    .ExpandTowards(0, hitGroundDuringMove ? 0 : -1.0E-5, 0);

                var stepColliders = t_stepColliderBuf ??= new List<Aabb>(64);
                stepColliders.Clear();
                CollectBlockColliders(world, expanded, stepColliders);

                // Try various step heights (uses stackalloc-friendly approach)
                var heightBuf = t_heightBuf ??= new List<float>(8);
                heightBuf.Clear();
                CollectCandidateStepHeights(stepBase, stepColliders, maxUpStep, (float)resolved.Y, heightBuf);

                for (int i = 0; i < heightBuf.Count; i++)
                {
                    Vec3d stepMovement = new Vec3d(movement.X, heightBuf[i], movement.Z);
                    Vec3d stepResolved = CollideWithShapes(stepMovement, stepBase, stepColliders);

                    if (stepResolved.HorizontalDistanceSqr() > resolved.HorizontalDistanceSqr())
                    {
                        double yOffset = entityBox.MinY - stepBase.MinY;
                        return stepResolved.Subtract(0, yOffset, 0);
                    }
                }
            }

            return resolved;
        }

        /// <summary>
        /// Collide movement against a list of shapes using axis-separated resolution.
        /// Matches Entity.collideWithShapes() — processes axes in order of smallest movement first.
        /// </summary>
        private static Vec3d CollideWithShapes(Vec3d movement, Aabb entityBox, List<Aabb> colliders)
        {
            if (colliders.Count == 0)
                return movement;

            Vec3d accumulated = Vec3d.Zero;
            int[] axisOrder = GetAxisStepOrder(movement);

            foreach (int axis in axisOrder)
            {
                double dist = movement.Get(axis);
                if (dist == 0.0) continue;

                double resolved = CollideAxis(axis, entityBox.Move(accumulated), colliders, dist);
                accumulated = accumulated.With(axis, resolved);
            }

            return accumulated;
        }

        /// <summary>
        /// Get axis processing order: Y first if moving down, otherwise smallest absolute movement first.
        /// Vanilla uses Direction.axisStepOrder(Vec3) which returns axes sorted by absolute movement.
        /// Returns a cached array - callers must not modify the result.
        /// </summary>
        private static int[] GetAxisStepOrder(Vec3d movement)
        {
            double absX = Math.Abs(movement.X);
            double absY = Math.Abs(movement.Y);
            double absZ = Math.Abs(movement.Z);

            if (absX > absZ)
            {
                if (absZ > absY)
                    return AxisOrder_YZX; // Y Z X
                if (absX > absY)
                    return AxisOrder_YXZ; // Y X Z
                return AxisOrder_XYZ; // X Y Z
            }
            else
            {
                if (absX > absY)
                    return AxisOrder_YXZ; // Y X Z
                if (absZ > absY)
                    return AxisOrder_YZX; // Y Z X
                return AxisOrder_ZYX; // Z Y X
            }
        }

        /// <summary>
        /// Collide along a single axis against all block shapes.
        /// Equivalent to Shapes.collide(axis, box, shapes, distance).
        /// </summary>
        private static double CollideAxis(int axis, Aabb entityBox, List<Aabb> colliders, double movement)
        {
            foreach (var collider in colliders)
            {
                if (Math.Abs(movement) < PhysicsConsts.CollisionEpsilon)
                    return 0.0;
                movement = entityBox.Collide(axis, collider, movement);
            }
            return movement;
        }

        /// <summary>
        /// Collect all block collision AABBs that overlap the given search area.
        /// Equivalent to BlockCollisions iterator in vanilla.
        /// Returns a new list (used by external callers like IsOnGround, NoCollision).
        /// </summary>
        public static List<Aabb> CollectBlockColliders(World world, Aabb searchBox)
        {
            var result = new List<Aabb>();
            CollectBlockColliders(world, searchBox, result);
            return result;
        }

        /// <summary>
        /// Collect all block collision AABBs into an existing list (avoids allocation on hot paths).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public static void CollectBlockColliders(World world, Aabb searchBox, List<Aabb> result)
        {

            int minBX = (int)Math.Floor(searchBox.MinX - PhysicsConsts.CollisionEpsilon) - 1;
            int maxBX = (int)Math.Floor(searchBox.MaxX + PhysicsConsts.CollisionEpsilon) + 1;
            int minBY = (int)Math.Floor(searchBox.MinY - PhysicsConsts.CollisionEpsilon) - 1;
            int maxBY = (int)Math.Floor(searchBox.MaxY + PhysicsConsts.CollisionEpsilon) + 1;
            int minBZ = (int)Math.Floor(searchBox.MinZ - PhysicsConsts.CollisionEpsilon) - 1;
            int maxBZ = (int)Math.Floor(searchBox.MaxZ + PhysicsConsts.CollisionEpsilon) + 1;

            for (int bx = minBX; bx <= maxBX; bx++)
            {
                for (int bz = minBZ; bz <= maxBZ; bz++)
                {
                    for (int by = minBY; by <= maxBY; by++)
                    {
                        Block block = world.GetBlock(new Location(bx, by, bz));
                        Aabb[] shapes = BlockShapes.GetShapes(block);

                        foreach (var shape in shapes)
                        {
                            Aabb worldShape = shape.Move(bx, by, bz);
                            if (worldShape.Intersects(searchBox))
                                result.Add(worldShape);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Collect candidate step-up heights into an existing list.
        /// Produces sorted distinct step heights between current resolved Y and maxUpStep.
        /// Always includes maxUpStep as a candidate.
        /// </summary>
        private static void CollectCandidateStepHeights(Aabb stepBase, List<Aabb> colliders, float maxUpStep, float currentY, List<float> heights)
        {
            int colliderCount = colliders.Count;
            for (int i = 0; i < colliderCount; i++)
            {
                float h = (float)(colliders[i].MaxY - stepBase.MinY);
                if (h > currentY && h <= maxUpStep)
                {
                    // Insert-sorted, skip duplicates
                    int heightCount = heights.Count;
                    int insertIdx = heightCount;
                    bool duplicate = false;
                    for (int j = 0; j < heightCount; j++)
                    {
                        if (heights[j] == h) { duplicate = true; break; }
                        if (heights[j] > h) { insertIdx = j; break; }
                    }
                    if (!duplicate)
                        heights.Insert(insertIdx, h);
                }
            }

            if (heights.Count == 0)
                heights.Add(maxUpStep);
        }

        /// <summary>
        /// Check if a position is on ground by testing for vertical collision below.
        /// Uses early exit to avoid materializing the full collider list.
        /// </summary>
        public static bool IsOnGround(World world, Aabb entityBox)
        {
            Aabb testBox = entityBox.ExpandTowards(0, -0.06, 0);
            return HasAnyBlockCollider(world, testBox);
        }

        /// <summary>
        /// Check if a given position has no collision (for checking if player fits somewhere).
        /// Uses early exit to avoid materializing the full collider list.
        /// </summary>
        public static bool NoCollision(World world, Aabb entityBox)
        {
            return !HasAnyBlockCollider(world, entityBox);
        }

        /// <summary>
        /// Returns true as soon as any block collider intersects the search box.
        /// Avoids allocating a list just to check Count > 0.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        private static bool HasAnyBlockCollider(World world, Aabb searchBox)
        {
            int minBX = (int)Math.Floor(searchBox.MinX - PhysicsConsts.CollisionEpsilon) - 1;
            int maxBX = (int)Math.Floor(searchBox.MaxX + PhysicsConsts.CollisionEpsilon) + 1;
            int minBY = (int)Math.Floor(searchBox.MinY - PhysicsConsts.CollisionEpsilon) - 1;
            int maxBY = (int)Math.Floor(searchBox.MaxY + PhysicsConsts.CollisionEpsilon) + 1;
            int minBZ = (int)Math.Floor(searchBox.MinZ - PhysicsConsts.CollisionEpsilon) - 1;
            int maxBZ = (int)Math.Floor(searchBox.MaxZ + PhysicsConsts.CollisionEpsilon) + 1;

            for (int bx = minBX; bx <= maxBX; bx++)
            {
                for (int bz = minBZ; bz <= maxBZ; bz++)
                {
                    for (int by = minBY; by <= maxBY; by++)
                    {
                        Block block = world.GetBlock(new Location(bx, by, bz));
                        Aabb[] shapes = BlockShapes.GetShapes(block);

                        foreach (var shape in shapes)
                        {
                            Aabb worldShape = shape.Move(bx, by, bz);
                            if (worldShape.Intersects(searchBox))
                                return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}
