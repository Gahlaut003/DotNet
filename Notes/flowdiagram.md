┌──────────────────────────────────────────────────────────────────────────────┐
│               1️⃣ 🌐 .NET Platform Boot & Environment                        │
├──────────────────────────────────────────────────────────────────────────────┤
│ 1. .NET Platform                                                             │
│    ├─ 🧩 Unified platform: .NET Core, .NET Framework, Xamarin, .NET Standard │
│    └─ 🎯 Supports Web, Desktop, Mobile, Cloud, IoT, AI                        │
│                                                                              │
│ 2. .NET Framework / .NET Core / .NET 6+                                      │
│    ├─ 🪟 .NET Framework: Windows-only, tightly coupled with OS               │
│    ├─ 🐧 .NET Core/.NET 5+: Cross-platform (Linux/macOS/Windows)             │
│    ├─ 🌟 .NET 6 (LTS) and .NET 7 (STS): Latest unified runtimes              │
│    ├─ 📦 Includes: CoreCLR, CoreFX (Base Class Libraries)                    │
│    └─ 🔁 Side-by-side runtime installations supported (Core and later)       │
│                                                                              │
│ 3. .NET Standard                                                             │
│    ├─ 📜 Defines uniform API surface (contract)                              │
│    ├─ 🤝 Enables library sharing across .NET Framework, Core, Xamarin       │
│    └─ ❗ Deprecated in favor of .NET 5+ unified base libraries               │
│                                                                              │
│ 4. ASP.NET Core Framework                                                    │
│    ├─ 🌐 Cross-platform high-performance web framework                       │
│    ├─ 💡 Built on top of .NET Core runtime & libraries                       │
│    ├─ 🚀 Minimal startup overhead, no System.Web dependency                  │
│    ├─ 🧱 Modular: You add only what you need (middleware pipeline)           │
│    └─ 🌟 Supports modern features like minimal APIs and Blazor               │
└──────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────────────────────────────────────────────────────┐
│               2️⃣ ⚙️ Application Launch & Hosting                           │
├──────────────────────────────────────────────────────────────────────────────┤
│ 4. App Launched (via CLI, double-click EXE, or runtime entry)               │
│    ├─ 🔰 Initiated by: User, OS Shell, dotnet CLI, or Hosting Layer         │
│    ├─ 🔎 dotnet.exe → loads apphost (EXE shim)                              │
│    ├─ 🔗 apphost → HostFXR.dll                                              │
│    └─ 🧩 HostFXR → HostPolicy.dll (resolves runtime, loads deps.json)       │
│                                                                              │
│ 5. CLR Initialization                                                        │
│    ├─ 🔰 Triggered by: HostFXR/HostPolicy                                   │
│    ├─ 📦 Loads CLR runtime (CoreCLR or legacy CLR)                          │
│    ├─ 🧠 Initializes:                                                       │
│    │   ├─ JIT Compiler (prepares native execution)                          │
│    │   ├─ Garbage Collector (heap setup)                                    │
│    │   ├─ ThreadPool & SynchronizationContext                               │
│    │   └─ AppDomain (isolated env)                                          │
│    ├─ 🪪 Parses app.config/runtimeconfig.json                               │
│    └─ 🧵 Initializes Main thread & hands off control to Entry Point (Main)  │
└──────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────────────────────────────────────────────────────┐
│               3️⃣ 🧠 CLR Core & Architecture                                │
├──────────────────────────────────────────────────────────────────────────────┤
│ 6. Common Language Runtime (CLR)                                            │
│    ├─ 🔰 Triggered by: HostFXR / HostPolicy / App Launch                    │
│    ├─ Provides managed execution environment                                │
│    ├─ 📌 Full Execution Flow (From App Start to Completion/Error):          │
│    │                                                                        │
│    │   1️⃣ App Launch → CLR Bootstrapped                                    │
│    │   ├─ HostFXR loads CoreCLR.dll and creates runtime instance            │
│    │   ├─ Initializes runtime (GC, JIT, TypeSystem, ThreadMgr)              │
│    │                                                                        │
│    │   2️⃣ Entry Assembly Loaded by Class Loader                            │
│    │   ├─ Reads .exe/.dll PE headers                                        │
│    │   ├─ Parses metadata, type definitions, IL                             │
│    │   └─ Resolves references (mscorlib/System.*, others)                   │
│    │                                                                        │
│    │   3️⃣ Main Method Invoked                                              │
│    │   ├─ JIT compiles Main() IL to native code                             │
│    │   ├─ Memory allocated for objects/args via GC                          │
│    │   ├─ CLR ThreadManager starts execution context                        │
│    │                                                                        │
│    │   🔁 While Code is Running:                                            │
│    │   ├─ JIT compiles more methods as needed (on demand)                   │
│    │   ├─ GC allocates/free memory during execution                         │
│    │   ├─ Interop handles any native calls (DLL, Win32)                     │
│    │   ├─ Exception Manager monitors for runtime faults                     │
│    │   ├─ ThreadPool executes async/workload code                           │
│    │   └─ Reflection or Emit may load more types at runtime                 │
│    │                                                                        │
│    │   🟩 If Execution Successful:                                          │
│    │   ├─ CLR finishes method stack                                         │
│    │   ├─ App completes Main() / Host waits for shutdown                    │
│    │   ├─ GC reclaims remaining objects                                     │
│    │   └─ Host triggers cleanup and calls Environment.Exit()                │
│    │                                                                        │
│    │   🟥 If Execution Fails:                                               │
│    │   ├─ CLR wraps error in System.Exception                               │
│    │   ├─ Stack unwinding begins → searches try/catch blocks                │
│    │   ├─ If handled → code resumes normally (finally block runs)           │
│    │   ├─ If unhandled → AppDomain.UnhandledException event fires           │
│    │   ├─ If fatal → FailFast() or native crash, logs dumped                │
│    │   └─ ASP.NET Core → middleware can intercept for error pipeline        │
│    │                                                                        │
│    ├─ Key Components & Functions:                                           │
│    │                                                                        │
│    │   📦 Class Loader                                                      │
│    │   ├─ Loads assemblies (PE → Metadata + IL)                             │
│    │   ├─ Parses CLI header, .text section, #~/#- metadata streams          │
│    │   ├─ Validates token signatures, assembly manifest                     │
│    │   └─ Builds type tree and method table (v-table)                       │
│    │                                                                        │
│    │   🔐 Security Engine (Legacy CAS model)                                │
│    │   ├─ Evaluates evidence and applies policy                             │
│    │   ├─ Checks sandbox, zone, signature, and publisher                    │
│    │   └─ CAS fully removed in .NET Core/5+, replaced with OS-level perms   │
│    │                                                                        │
│    │   🧠 JIT Compiler                                                      │
│    │   ├─ IL → Native x64/ARM64 code on method invocation                   │
│    │   ├─ Uses tiered JIT & code caching (via memory pages)                 │
│    │   ├─ Performs optimizations: inlining, loop unrolling, SSA             │
│    │   └─ JIT`s code stored in loader heap, optionally profiled             │
│    │                                                                        │
│    │   🗂️ Code Manager                                                     │
│    │   ├─ Manages execution of IL and native code                           │
│    │   ├─ Tracks method-to-native code mappings                             │
│    │   ├─ Handles stack walking for exceptions and debugging                │
│    │   └─ Coordinates with JIT and GC for runtime optimizations             │
│    │                                                                        │
│    │   ♻️ Garbage Collector (GC)                                            │
│    │   ├─ Segmented heap (LOH, SOH: Gen0, Gen1, Gen2)                       │
│    │   ├─ Uses mark-and-sweep + compaction                                  │
│    │   ├─ Allocation: Bump pointer + Gen0 fast path                         │
│    │   ├─ Ephemeral GC threads run in background                            │
│    │   └─ Safe points inserted for managed thread suspension                │
│    │                                                                        │
│    │   🔄 Exception Manager                                                 │
│    │   ├─ Wraps CPU exceptions (SEH) into managed System.Exception          │
│    │   ├─ Maintains stack unwind tables                                     │
│    │   ├─ Calls stack frames in reverse for try/catch blocks                │
│    │   └─ Escalates unhandled to AppDomain / Environment.FailFast()         │
│    │                                                                        │
│    │   🧵 Thread Support                                                    │
│    │   ├─ Manages CLR threads, tasks, async contexts                        │
│    │   ├─ ThreadPool: Work-stealing queue + hill-climbing thread tuning     │
│    │   └─ Supports SynchronizationContext for UI frameworks                 │
│    │                                                                        │
│    │   🧩 Interop Services (P/Invoke & COM Interop)                         │
│    │   ├─ Generates thunk stubs for managed → unmanaged transitions         │
│    │   ├─ Uses marshalling engine (Marshaler.cs) for layout conversion      │
│    │   └─ Maintains COM RCW/CCW wrappers + ABI layout matching              │
│    │                                                                        │
│    │   📑 Metadata & Type System                                            │
│    │   ├─ Metadata tables: TypeDef, MethodDef, MemberRef, etc.              │
│    │   ├─ Enforces Common Type System (CTS) & language neutrality           │
│    │   ├─ Used by reflection, dynamic IL emit                               │
│    │   └─ TypeHandle points to MethodTable with v-table pointers            │
│                                                                              │
│    └─ ✅ If Error Occurs:                                                   │
│       ├─ Exception sent to CLR Exception Dispatcher                         │
│       ├─ Stack trace is captured, HRESULT mapped if interop boundary        │
│       ├─ If no catch → triggers AppDomain.UnhandledException                │
│       ├─ If final fail → calls FailFast(), process termination              │
│       └─ ASP.NET: Middleware intercepts → shows custom error/500 page       │
└──────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────────────────────────────────────────────────────┐
│               4️⃣ 💾 Code Compilation & Execution                           │
├──────────────────────────────────────────────────────────────────────────────┤
│ 9. Source Code Compilation                                                  │
│    ├─ 🔧 Compiled to CIL/MSIL using language-specific compilers            │
│    │   ├─ C#: csc.exe (Roslyn)                                              │
│    │   └─ VB.NET: vbc.exe                                                   │
│    ├─ 🔍 Compiler parses syntax tree (AST)                                  │
│    ├─ Generates:                                                            │
│    │   ├─ IL code (MSIL/CIL)                                                │
│    │   ├─ Assembly metadata                                                 │
│    │   ├─ Manifest (assembly identity, references)                          │
│    │   └─ Debug symbols (.pdb) if in debug mode                             │
│    └─ Output: Portable Executable (.dll / .exe)                             │
│                                                                              │
│10. Assembly Structure                                                       │
│    ├─ 💡 Assembly is the smallest deployment & versioning unit              │
│    ├─ Contains:                                                             │
│    │   ├─ Portable Executable (PE) Header                                   │
│    │   ├─ CLR Header (entry point, flags)                                   │
│    │   ├─ Metadata: types, methods, references                              │
│    │   ├─ Intermediate Language (IL) code                                   │
│    │   ├─ Manifest (name, culture, version, public key)                     │
│    │   ├─ Optional: Security declarations                                   │
│    │   └─ Embedded resources (images, strings, configs)                     │
│    └─ Used by: CLR Class Loader during runtime                              │
│                                                                              │
│11. Assemblies                                                               │
│    ├─ 🧱 Types of Assemblies:                                               │
│    │   ├─ Static: Compiled at build time                                    │
│    │   └─ Dynamic: Created at runtime using Reflection.Emit                 │
│    ├─ 🔄 Classification:                                                    │
│    │   ├─ Private: Deployed with app in same directory                      │
│    │   ├─ Public (Shared): Stored in GAC (signed + versioned)               │
│    │   └─ Satellite: Contains culture-specific/localized resources          │
│    ├─ 🔍 Assembly Identity (4-part): Name, Version, Culture, Public Key     │
│    └─ Stored in:                                                            │
│        ├─ Application Base Directory                                        │
│        └─ Global Assembly Cache (GAC) for shared assemblies                 │
│                                                                              │
│12. Strong Named Assemblies                                                  │
│    ├─ 🔒 Digitally signed with public/private key pair                      │
│    ├─ Signature ensures integrity + unique identity                         │
│    ├─ Required for:                                                         │
│    │   ├─ GAC deployment                                                    │
│    │   ├─ Side-by-side versioning                                           │
│    │   └─ Assembly version binding & redirects                              │
│    └─ Created using:                                                        │
│        ├─ sn.exe (Strong Name tool)                                         │
│        ├─ signtool.exe for Authenticode signing                             │
│        └─ AssemblyKeyFile or Delay Signing options                          │
└──────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────────────────────────────────────────────────────┐
│               5️⃣ 🧬 Execution by CLR & JIT                                │
├──────────────────────────────────────────────────────────────────────────────┤
│13. Common Type System (CTS)                                                │
│    ├─ Defines: unified type system for all .NET languages                  │
│    ├─ Supports: Value types, Reference types, Interfaces, Delegates        │
│    ├─ Enables: Cross-language inheritance & type safety                    │
│    └─ Foundation for metadata and verification                             │
│                                                                              │
│14. Common Language Specification (CLS)                                     │
│    ├─ Defines: subset of CTS types all .NET languages must support         │
│    ├─ Ensures: cross-language compatibility                                │
│    └─ E.g., unsigned types not CLS-compliant (VB.NET doesn`t support)      │
│                                                                              │
│15. Just-In-Time Compilation (JITers)                                       │
│    ├─ 🔥 Triggered on method invocation (first-time only unless cached)    │
│    ├─ Converts MSIL/CIL → Native CPU-specific instructions                 │
│    ├─ Uses: metadata & CLR services during compilation                     │
│    ├─ Outputs: Machine instructions in memory                              │
│    ├─ Stores native code in: JIT Code Heap (in memory)                     │
│    ├─ Types of JIT:                                                        │
│    │   ├─ Normal-JIT: Compiles as methods are called (default)             │
│    │   ├─ Pre-JIT (Ngen/AOT): Compile entire assembly at install time      │
│    │   └─ Econo-JIT: Optimized for devices with limited resources          │
│    └─ Includes:                                                            │
│        ├─ Method token resolution                                           │
│        ├─ Security checks (CAS)                                            │
│        └─ Inline IL optimizations                                          │
│                                                                              │
│16. Virtual Execution System (VES)                                          │
│    ├─ Part of: Common Language Infrastructure (CLI)                        │
│    ├─ Abstracts execution of IL code                                       │
│    ├─ Interacts with:                                                      │
│    │   ├─ Class Loader                                                     │
│    │   ├─ Garbage Collector                                                │
│    │   ├─ JIT Compiler                                                     │
│    │   ├─ Metadata Engine                                                  │
│    │   └─ Security Manager                                                 │
│    ├─ Ensures:                                                             │
│    │   ├─ Correct type loading & execution                                │
│    │   ├─ Execution policy enforcement                                     │
│    │   └─ Exception handling pipeline                                      │
│    └─ Coordinates: Managed-to-Native transitions                           │
└──────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────────────────────────────────────────────────────┐
│               6️⃣ 🔃 Runtime Behavior                                       │
├──────────────────────────────────────────────────────────────────────────────┤
│17. Application Domain (AppDomain / AssemblyLoadContext)                    │
│    ├─ AppDomain: Legacy isolation mechanism for assemblies in .NET         │
│    │             Framework. Deprecated in .NET Core and later.               │
│    ├─ AssemblyLoadContext: Modern replacement for AppDomain in .NET         │
│    │   Core and later. Provides assembly isolation and dynamic loading.     │
│    ├─ Manages: Assembly resolution, metadata isolation                      │
│    ├─ ⚙️ Internal: Maintains separate memory maps per context               │
│    └─ 🧼 Context unload: Uses reference counting + GC reachability          │
│                                                                              │
│18. Managed vs Unmanaged Code                                               │
│    ├─ Managed: Runs on CLR (C#, VB.NET)                                     │
│    │   ├─ Backed by metadata, method tables, vtables                        │
│    │   └─ Object layout: Type handle + sync block index                    │
│    ├─ Unmanaged: Native C/C++, COM                                          │
│    │   ├─ P/Invoke: Marshals parameters to native memory layout            │
│    │   └─ COM Interop: Uses vtable thunk and RCW (Runtime Callable Wrapper)│
│    └─ Transition: Managed ↔ Unmanaged via interop services                 │
│                                                                              │
│19. Garbage Collection (GC)                                                 │
│    ├─ 🔁 Automatic memory cleanup                                           │
│    ├─ Generations: Gen0 (ephemeral), Gen1, Gen2, LOH                        │
│    ├─ Tracking: Write barriers, card tables, remembered sets               │
│    ├─ Execution: Stop-the-world model, server/workstation modes            │
│    ├─ Large Object Heap (LOH): Objects > 85K, non-compacting by default    │
│    ├─ Finalization: Background thread invokes Finalize()/Dispose()         │
│    └─ 🔒 Object headers: Track sync info + type handle per instance         │
│                                                                              │
│20. Code Access Security (CAS)                                              │
│    ├─ Enforces permission policies at runtime                              │
│    ├─ Uses evidence: Strong name, zone, hash, publisher                    │
│    ├─ Stack walk: Ensures all calling methods meet policy                  │
│    ├─ Partially trusted assemblies restricted                              │
│    └─ ❌ Deprecated in .NET Core+; replaced by OS sandboxing mechanisms     │
└──────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────────────────────────────────────────────────────┐
│               7️⃣ 🛠️ .NET Developer Tools                                 │
├──────────────────────────────────────────────────────────────────────────────┤
│21. Tools                                                                   │
│    ├─ 🧩 ILDASM (IL Disassembler)                                          │
│    │   ├─ 🪟 GUI-based tool to decompile assemblies                        │
│    │   ├─ 🔍 Parses PE header, CLR metadata tables                         │
│    │   └─ 📜 Outputs readable CIL from MSIL                                │
│                                                                              │
│    ├─ 🧱 ILASM (IL Assembler)                                               │
│    │   ├─ 🔧 Converts CIL text (.il) → .NET assembly (.exe/.dll)           │
│    │   ├─ 🧠 Creates: CLR header, metadata, manifest                        │
│    │   └─ 🔗 Uses fusion metadata API under the hood                       │
│                                                                              │
│    ├─ 🗂️ GACUtil                                                           │
│    │   ├─ 🛠️ Registers/Unregisters assemblies in Global Assembly Cache     │
│    │   ├─ 🔐 Strong-named assemblies only                                  │
│    │   └─ 🧾 Internally updates GAC folder under %WINDIR%\assembly         │
│                                                                              │
│    ├─ 🔐 SN.exe (Strong Name Tool)                                         │
│    │   ├─ 🗝️ Generates key pairs (public/private)                          │
│    │   ├─ 🏷️ Signs assemblies with strong name                             │
│    │   └─ ✅ Verifies signatures, helps enforce assembly identity          │
│                                                                              │
│    ├─ 📊 CLR Profiler                                                      │
│    │   ├─ 🧮 Visualizes memory allocations and GC behavior                  │
│    │   ├─ 🧵 Hooks into runtime via Profiling API                          │
│    │   └─ 🔬 Useful for finding object leaks or GC inefficiencies          │
│                                                                              │
│    ├─ 🐞 Debugger (e.g., VS, SOS, WinDbg)                                   │
│    │   ├─ 🗂️ Debug symbols: .pdb maps IL to source                         │
│    │   ├─ 📦 SOS.dll (Son of Strike): Runtime inspection extension         │
│    │   └─ 🎯 Uses CLR debugging services (ICorDebug, MDbg engine)          │
└──────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────────────────────────────────────────────────────┐
│               📘 Glossary: Key CLR & .NET Terms                              │
├──────────────────────────────────────────────────────────────────────────────┤
│ 🔁 IL (Intermediate Language)                                                │
│    └─ CPU-independent bytecode emitted by .NET compiler (C#/VB/F#)          │
│                                                                              │
│ ⚙️  JIT (Just-In-Time Compiler)                                              │
│    └─ Converts IL → native CPU instructions at method invocation time       │
│                                                                              │
│ ♻️ GC (Garbage Collector)                                                   │
│    └─ Automates memory management by collecting unused managed objects      │
│                                                                              │
│ 🧩 AppDomain                                                                 │
│    └─ Isolated runtime unit inside a process (deprecated in .NET Core)      │
└──────────────────────────────────────────────────────────────────────────────┘

