# MCC Performance Optimization Plan

Target: Minecraft 1.21.11 (Protocol18Handler)

## Methodology

Static analysis of hot-path code informed by the MCC architecture (per-packet at 100s/sec,
per-tick at 20/sec, per-chunk-load) to identify allocation-heavy and lookup-heavy patterns.
Changes are validated by successful compilation with zero new warnings.

---

## Phase 1: CollisionDetector Allocation Elimination [COMPLETED]

**Hotspot**: `Physics/CollisionDetector.cs` - called 20+ times/sec on physics tick  
**Problem**: Every `Collide()` call allocated 2+ `List<Aabb>`, 1 `SortedSet<float>`, 1 `float[]`, and 6 `int[]`  
**Changes**:
- [x] `[ThreadStatic]` reusable `List<Aabb>` buffers for collider collection (eliminates ~40 list allocs/sec)
- [x] Cached static `int[]` axis-order arrays (eliminates ~120 array allocs/sec from `GetAxisStepOrder`)
- [x] In-place sorted `List<float>` replaces `SortedSet<float>` + `float[]` for step heights
- [x] `HasAnyBlockCollider()` with early exit for `IsOnGround`/`NoCollision` (avoids materializing full list)
- [x] Void overload of `CollectBlockColliders` that fills an existing list

**Risk**: Thread-local buffers assume single-threaded physics (validated by architecture review).

## Phase 2: FrozenDictionary for Hot-Path Lookups [COMPLETED]

**Hotspot**: `BlockShapes.GetShapes()` and `PacketTypePalette.GetIncomingTypeById()`  
**Problem**: `Dictionary.TryGetValue` used for read-only lookups on every packet and every block collision check  
**Changes**:
- [x] `BlockShapes.stateToShape` converted to `FrozenDictionary<int, Aabb[]>` (~50% faster reads)
- [x] All `PacketTypePalette` forward/reverse mappings frozen (8 dictionaries per palette instance)

**Risk**: None - data is immutable after construction. FrozenDictionary is a drop-in replacement.

## Phase 3: DataTypes Hot-Path Micro-Optimizations [COMPLETED]

**Hotspot**: `DataTypes.ReadNextVarLong()` - called frequently in packet parsing  
**Changes**:
- [x] Added `[MethodImpl(AggressiveInlining | AggressiveOptimization)]`
- [x] Inlined `cache.Dequeue()` directly instead of going through `ReadNextByte()` indirection

**Risk**: Minimal - same semantics, just avoids virtual dispatch overhead.

## Phase 4: Movement A* Double-Lookup Fix [COMPLETED]

**Hotspot**: `Movement.CalculatePath()` A* inner loop  
**Problem**: `ContainsKey()` + `[key]` pattern does two hash lookups instead of one  
**Changes**:
- [x] Replaced with single `TryGetValue()` call

**Risk**: None - identical semantics, fewer hash lookups.

---

## Rejected Optimizations

| Candidate | Reason for Rejection |
|-----------|---------------------|
| Replace `Queue<byte>` with `Span<byte>` in DataTypes | Too broad a change, touches hundreds of call sites |
| Object pool for Chunk objects | Low frequency (chunk load), high complexity |
| Parallel chunk section processing | Threading risks outweigh benefits for client workload |
| ConcurrentDictionary pre-sizing for World.chunks | Already uses default sizing, marginal benefit |
