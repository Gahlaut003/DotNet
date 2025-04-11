# 🔁 MEMORY CLEANUP HIERARCHY IN C# (.NET)

```text
+================================================================================================+
| 🔁 MEMORY CLEANUP HIERARCHY IN C# (.NET)                                                       |
+================================================================================================+
|                                    🧠 Developer Code                                           |
|                                           │                                                    |
|                                           ▼                                                    |
|                              +-------------------------+                                      |
|                              |   IDisposable Interface |   ← (Optional)                       |
|                              +-------------------------+                                      |
|                                           │                                                    |
|                                           ▼                                                    |
|                              +----------------------------+                                   |
|                              |        Dispose()           |  ← (Explicit Cleanup)             |
|                              +----------------------------+                                   |
|                                           │                                                    |
|                                           ▼                                                    |
|                     +----------------------------------------------+                          |
|                     | GC.SuppressFinalize(this)                   |  ← Prevent Finalizer if  |
|                     | (Called inside Dispose if Finalizer exists) |     already cleaned up   |
|                     +----------------------------------------------+                          |
|                                                                                               |
|──────────────────────────── FALLBACK IF Dispose NOT called ───────────────────────────────────|
|                                                                                               |
|                                           ▼                                                    |
|                              +----------------------------+                                   |
|                              |         Finalizer          |  ← `~ClassName()`                |
|                              +----------------------------+                                   |
|                                           │                                                    |
|                                           ▼                                                    |
|                          [Placed in Finalization Queue by CLR]                                |
|                                           │                                                    |
|                                           ▼                                                    |
|                          +----------------------------+                                       |
|                          |   GC (Garbage Collector)   |  ← Runs when memory is low            |
|                          +----------------------------+                                       |
|                                           │                                                    |
|              ┌──────────────────────────────────────────────────────────────────────────┐     |
|              ▼                                                                          ▼     |
|  +-------------------+   +-------------------+   +-------------------+   +------------------+ |
|  |   Mark Phase      | → |   Sweep Phase     | → |   Compact Phase   | → |   Promote Phase  | |
|  +-------------------+   +-------------------+   +-------------------+   +------------------+ |
|                                                                                               |
|  GC Generations:                                                                              |
|    - Gen 0: Newly allocated short-lived objects.                                              |
|    - Gen 1: Survived Gen 0, mid-lived objects.                                                |
|    - Gen 2: Long-lived objects. Collected less frequently.                                   |
+================================================================================================+
| ➤ Order of Responsibility:                                                                    |
|    1️⃣ Developer → Implements IDisposable + Dispose (preferred)                              |
|    2️⃣ If Dispose not called → Finalizer runs (fallback)                                     |
|    3️⃣ GC invokes Finalizer and reclaims memory                                              |
+------------------------------------------------------------------------------------------------+
| ✅ Best Practice:                                                                             |
| - Use `Dispose()` deterministically via `using` statement.                                    |
| - Always call `GC.SuppressFinalize(this)` if finalizer exists.                               |
| - Avoid Finalizers unless necessary for unmanaged resource cleanup.                          |
+================================================================================================+

🧠 **Explanation**

**Garbage Collection (GC)**  
GC is the .NET automatic memory manager. It frees up memory by reclaiming objects no longer in use.
- **Phases:** Mark, Sweep, Compact, Promote.
- **Generations:** Gen 0, Gen 1, Gen 2.
- **Non-deterministic:** You don’t control when it runs.

**Dispose()**  
The Dispose method from `IDisposable` allows explicit cleanup of unmanaged resources.
- Called directly or via `using` block.
- Should include `GC.SuppressFinalize(this)`.

**Finalizer (~ClassName)**  
A fallback if Dispose is not called. It’s triggered by the GC before memory is reclaimed.
- Slower, non-deterministic.
- Avoid unless unmanaged resources are used.
```
