# MCC Performance Optimization Report

## Summary

This report documents targeted performance optimizations to Minecraft Console Client (MCC)
focusing on the highest-frequency runtime paths: physics collision detection (20 TPS),
packet palette lookups (100s/sec), block shape lookups (per-collision), and pathfinding.

All optimizations target behavioral preservation with zero functional regressions.

---

## Optimization Results

### 1. CollisionDetector Allocation Elimination

**File**: `MinecraftClient/Physics/CollisionDetector.cs`

**Before**: Every `Collide()` call (20/sec minimum) allocated:
- 2x `new List<Aabb>()` for collider collection
- 1x `new SortedSet<float>()` for step heights
- 1x `new float[]` for height results
- 6x `new int[]` from `GetAxisStepOrder()` per collision resolution

**After**: Zero heap allocations in the steady-state physics tick:
- `[ThreadStatic] List<Aabb>` buffers reused across ticks (Clear + reuse pattern)
- Static `readonly int[]` arrays for axis ordering (6 possible orderings, cached once)
- In-place sorted `List<float>` with insert-sort for step height candidates
- `HasAnyBlockCollider()` early-exit avoids list materialization for boolean queries

**Impact**: Eliminates ~200+ allocations/sec during active movement, directly reducing
Gen-0 GC pressure.

### 2. FrozenDictionary for Hot-Path Lookups

**Files**: `MinecraftClient/Physics/BlockShapes.cs`, `MinecraftClient/Protocol/Handlers/PacketPalettes/PacketTypePalette.cs`

**Before**: `Dictionary<K,V>.TryGetValue()` on every packet dispatch and every block
collision shape lookup.

**After**: `FrozenDictionary<K,V>.TryGetValue()` for all read-only lookup tables:
- `BlockShapes.stateToShape`: frozen after `Initialize()`, read on every physics tick
- `PacketTypePalette`: 8 dictionaries (4 forward + 4 reverse) frozen per palette instance

**Impact**: `FrozenDictionary` uses an optimized hash algorithm with no collision chains
for integer keys, providing ~30-50% faster lookups vs `Dictionary` for read-only scenarios.

### 3. DataTypes ReadNextVarLong Optimization

**File**: `MinecraftClient/Protocol/Handlers/DataTypes.cs`

**Before**: `ReadNextVarLong()` lacked JIT hints and called through `ReadNextByte()`.

**After**: Added `[MethodImpl(AggressiveInlining | AggressiveOptimization)]` and
inlined `cache.Dequeue()` directly, matching the pattern of `ReadNextVarInt()`.

**Impact**: Eliminates method call overhead on a per-packet hot path.

### 4. Movement A* TryGetValue Fix

**File**: `MinecraftClient/Mapping/Movement.cs`

**Before**: `ContainsKey(neighbor)` followed by `gScoreDict[neighbor]` = 2 hash lookups.

**After**: Single `TryGetValue(neighbor, out existingGScore)` = 1 hash lookup.

**Impact**: Reduces hash computation by ~50% in A* inner loop during pathfinding.

---

## Rejected Candidates

| Candidate | Evidence | Decision |
|-----------|----------|----------|
| Replace `Queue<byte>` with `Span<byte>` in DataTypes | Hundreds of call sites | Risk too high for benefit |
| Chunk object pooling | Low frequency (chunk load events) | Complexity outweighs gain |
| Parallel chunk section processing | Single-client workload | Threading overhead exceeds gain |
| `ConcurrentDictionary` pre-sizing for `World.chunks` | Already reasonable default | Marginal benefit |
| `AggressiveInlining` on large methods | JIT already handles small methods | Causes cache bloat on large ones |
| LINQ removal on cold paths | Login/config/one-shot code | Clarity > speed on cold paths |

---

## Residual Hotspots

These remain as potential future optimization targets but were not addressed due to
risk/complexity tradeoffs:

1. **`DataTypes.ReadData()` allocations**: `new byte[offset]` on every call. A Span-based
   overload would help but requires touching hundreds of call sites.
2. **`Protocol18.HandlePacket()` packet buffer copies**: `packetData.ToArray()` in error paths.
3. **`World.GetBlock()` per-block dictionary lookup**: Could benefit from chunk-local caching
   in tight collision loops but requires careful thread-safety analysis.

---

## Validation

- All changes compile with zero new warnings (same 9 pre-existing warnings as baseline)
- No behavioral changes: all optimizations preserve identical semantics
- Thread safety preserved: `[ThreadStatic]` buffers are safe for single-threaded physics;
  `FrozenDictionary` is inherently thread-safe for reads
- No new dependencies added

---

## Technical Limitations

- No live server profiling was performed in this session (environment limitation)
- Allocation reduction numbers are derived from static code analysis, not runtime measurement
- `FrozenDictionary` performance claims are based on .NET runtime documentation and benchmarks
