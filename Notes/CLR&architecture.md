# 🌐 1️⃣ .NET Platform Boot & Environment

## Table of Contents
- [1️⃣ .NET Platform Boot & Environment](#1️⃣-net-platform-boot--environment)
- [2️⃣ Application Launch & Hosting](#2️⃣-application-launch--hosting)
- [3️⃣ CLR Core & Architecture](#3️⃣-clr-core--architecture)
- [4️⃣ Code Compilation & Execution](#4️⃣-code-compilation--execution)
- [5️⃣ Execution by CLR & JIT](#5️⃣-execution-by-clr--jit)
- [6️⃣ Runtime Behavior](#6️⃣-runtime-behavior)
- [7️⃣ .NET Developer Tools](#7️⃣-net-developer-tools)
- [📘 Glossary](#📘-glossary)

---

## 1️⃣ .NET Platform Boot & Environment

### 1. .NET Platform
- 🧩 **Unified platform**: .NET Core, .NET Framework, Xamarin, .NET Standard
- 🎯 **Supports**: Web, Desktop, Mobile, Cloud, IoT, AI

### 2. .NET Framework / .NET Core / .NET 6+
| Feature               | .NET Framework      | .NET Core / .NET 5+ |
|-----------------------|---------------------|---------------------|
| Platform Support      | Windows-only        | Cross-platform      |
| Deployment            | In-place updates    | Side-by-side        |
| Performance           | Moderate            | High                |

### 3. .NET Standard
- 📜 **Defines**: Uniform API surface (contract)
- 🤝 **Enables**: Library sharing across .NET Framework, Core, Xamarin
- ❗ **Deprecated**: Replaced by .NET 5+ unified base libraries

### 4. ASP.NET Core Framework
- 🌐 **Cross-platform high-performance web framework**
- 💡 **Built on**: .NET Core runtime & libraries
- 🚀 **Minimal startup overhead**: No System.Web dependency
- 🧱 **Modular**: Add only what you need (middleware pipeline)
- 🌟 **Supports modern features**: Minimal APIs and Blazor

#### Example: Minimal API in ASP.NET Core
```csharp
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello, ASP.NET Core!");
app.Run();
```

---

## 2️⃣ ⚙️ Application Launch & Hosting

### 4. App Launched
- 🔰 **Initiated by**: User, OS Shell, dotnet CLI, or Hosting Layer
- 🔎 `dotnet.exe` → Loads apphost (EXE shim)
- 🔗 `apphost` → HostFXR.dll
- 🧩 `HostFXR` → HostPolicy.dll (resolves runtime, loads deps.json)

### 5. CLR Initialization
- 🔰 **Triggered by**: HostFXR/HostPolicy
- 📦 **Loads**: CLR runtime (CoreCLR or legacy CLR)
- 🧠 **Initializes**:
  - JIT Compiler (prepares native execution)
  - Garbage Collector (heap setup)
  - ThreadPool & SynchronizationContext
  - AppDomain (isolated environment)
- 🪪 **Parses**: `app.config` / `runtimeconfig.json`
- 🧵 **Initializes**: Main thread & hands off control to Entry Point (Main)

---

## 3️⃣ 🧠 CLR Core & Architecture

### 6. Common Language Runtime (CLR)
- 🔰 **Triggered by**: HostFXR / HostPolicy / App Launch
- 📌 **Full Execution Flow**:
  1. **App Launch → CLR Bootstrapped**
     - HostFXR loads CoreCLR.dll and creates runtime instance
     - Initializes runtime (GC, JIT, TypeSystem, ThreadMgr)
  2. **Entry Assembly Loaded by Class Loader**
     - Reads `.exe` / `.dll` PE headers
     - Parses metadata, type definitions, IL
     - Resolves references (mscorlib/System.*, others)
  3. **Main Method Invoked**
     - JIT compiles `Main()` IL to native code
     - Memory allocated for objects/args via GC
     - CLR ThreadManager starts execution context

#### Example: JIT Compilation
```csharp
public static void Main()
{
    Console.WriteLine("Hello, JIT!");
}
// The above code is compiled to IL and JIT-compiled to native code at runtime.
```

  4. **While Code is Running**:
     - JIT compiles more methods as needed (on demand)
     - GC allocates/free memory during execution
     - Interop handles any native calls (DLL, Win32)
     - Exception Manager monitors for runtime faults
     - ThreadPool executes async/workload code
     - Reflection or Emit may load more types at runtime

> **Note**: If execution fails, the CLR wraps the error in `System.Exception` and escalates it to `AppDomain.UnhandledException` or `Environment.FailFast()`.

---

## 4️⃣ 💾 Code Compilation & Execution

### 9. Source Code Compilation
- 🔧 **Compiled to CIL/MSIL** using language-specific compilers:
  - C#: `csc.exe` (Roslyn)
  - VB.NET: `vbc.exe`
- 🔍 **Compiler parses**: Syntax tree (AST)
- **Generates**:
  - IL code (MSIL/CIL)
  - Assembly metadata
  - Manifest (assembly identity, references)
  - Debug symbols (`.pdb`) if in debug mode
- **Output**: Portable Executable (`.dll` / `.exe`)

#### Example: Compiling a C# Program
```plaintext
csc Program.cs
```

---

## 5️⃣ 🧬 Execution by CLR & JIT

### 13. Common Type System (CTS)
- **Defines**: Unified type system for all .NET languages
- **Supports**: Value types, Reference types, Interfaces, Delegates
- **Enables**: Cross-language inheritance & type safety
- **Foundation for**: Metadata and verification

### 14. Common Language Specification (CLS)
- **Defines**: Subset of CTS types all .NET languages must support
- **Ensures**: Cross-language compatibility
- **Example**: Unsigned types not CLS-compliant (VB.NET doesn’t support)

### 15. Just-In-Time Compilation (JITers)
- 🔥 **Triggered on method invocation** (first-time only unless cached)
- **Converts**: MSIL/CIL → Native CPU-specific instructions
- **Uses**: Metadata & CLR services during compilation
- **Outputs**: Machine instructions in memory
- **Stores native code in**: JIT Code Heap (in memory)
- **Types of JIT**:
  - Normal-JIT: Compiles as methods are called (default)
  - Pre-JIT (Ngen/AOT): Compile entire assembly at install time
  - Econo-JIT: Optimized for devices with limited resources
- **Includes**:
  - Method token resolution
  - Security checks (CAS)
  - Inline IL optimizations

### 16. Virtual Execution System (VES)
- **Part of**: Common Language Infrastructure (CLI)
- **Abstracts execution of IL code**
- **Interacts with**:
  - Class Loader
  - Garbage Collector
  - JIT Compiler
  - Metadata Engine
  - Security Manager
- **Ensures**:
  - Correct type loading & execution
  - Execution policy enforcement
  - Exception handling pipeline
- **Coordinates**: Managed-to-Native transitions

---

## 6️⃣ 🔃 Runtime Behavior

### 17. Application Domain (AppDomain / AssemblyLoadContext)
- **AppDomain**: Legacy isolation mechanism for assemblies in .NET Framework. Deprecated in .NET Core and later.
- **AssemblyLoadContext**: Modern replacement for AppDomain in .NET Core and later. Provides assembly isolation and dynamic loading.
- **Manages**: Assembly resolution, metadata isolation
- ⚙️ **Internal**: Maintains separate memory maps per context
- 🧼 **Context unload**: Uses reference counting + GC reachability

### 18. Managed vs Unmanaged Code
- **Managed**: Runs on CLR (C#, VB.NET)
  - Backed by metadata, method tables, vtables
  - Object layout: Type handle + sync block index
- **Unmanaged**: Native C/C++, COM
  - P/Invoke: Marshals parameters to native memory layout
  - COM Interop: Uses vtable thunk and RCW (Runtime Callable Wrapper)
- **Transition**: Managed ↔ Unmanaged via interop services

### 19. Garbage Collection (GC)
- 🔁 **Automatic memory cleanup**
- **Generations**: Gen0 (ephemeral), Gen1, Gen2, LOH
- **Tracking**: Write barriers, card tables, remembered sets
- **Execution**: Stop-the-world model, server/workstation modes
- **Large Object Heap (LOH)**: Objects > 85K, non-compacting by default
- **Finalization**: Background thread invokes `Finalize()`/`Dispose()`
- 🔒 **Object headers**: Track sync info + type handle per instance

### 20. Code Access Security (CAS)
- **Enforces permission policies at runtime**
- **Uses evidence**: Strong name, zone, hash, publisher
- **Stack walk**: Ensures all calling methods meet policy
- **Partially trusted assemblies restricted**
- ❌ **Deprecated in .NET Core+**; replaced by OS sandboxing mechanisms

---

## 7️⃣ 🛠️ .NET Developer Tools

### 21. Tools
- 🧩 **ILDASM (IL Disassembler)**
  - 🪟 GUI-based tool to decompile assemblies
  - 🔍 Parses PE header, CLR metadata tables
  - 📜 Outputs readable CIL from MSIL

#### Example: Using ILDASM
- Open an assembly in ILDASM to view its metadata and IL code.
```plaintext
ildasm MyAssembly.dll
```

- 🧱 **ILASM (IL Assembler)**
  - 🔧 Converts CIL text (`.il`) → .NET assembly (`.exe`/`.dll`)
  - 🧠 Creates: CLR header, metadata, manifest
  - 🔗 Uses fusion metadata API under the hood

- 🗂️ **GACUtil**
  - 🛠️ Registers/Unregisters assemblies in Global Assembly Cache
  - 🔐 Strong-named assemblies only
  - 🧾 Internally updates GAC folder under `%WINDIR%\assembly`

#### Example: Using GACUtil
- Register an assembly in the Global Assembly Cache (GAC).
```plaintext
gacutil -i MyAssembly.dll
```

- 🔐 **SN.exe (Strong Name Tool)**
  - 🗝️ Generates key pairs (public/private)
  - 🏷️ Signs assemblies with strong name
  - ✅ Verifies signatures, helps enforce assembly identity

- 📊 **CLR Profiler**
  - 🧮 Visualizes memory allocations and GC behavior
  - 🧵 Hooks into runtime via Profiling API
  - 🔬 Useful for finding object leaks or GC inefficiencies

- 🐞 **Debugger (e.g., VS, SOS, WinDbg)**
  - 🗂️ Debug symbols: `.pdb` maps IL to source
  - 📦 `SOS.dll` (Son of Strike): Runtime inspection extension
  - 🎯 Uses CLR debugging services (`ICorDebug`, MDbg engine)

---

## 📘 Glossary

| Term                  | Description                                                                 |
|-----------------------|-----------------------------------------------------------------------------|
| 🔁 **IL (Intermediate Language)** | CPU-independent bytecode emitted by .NET compiler (C#/VB/F#)       |
| ⚙️ **JIT (Just-In-Time Compiler)** | Converts IL → native CPU instructions at method invocation time    |
| ♻️ **GC (Garbage Collector)**      | Automates memory management by collecting unused managed objects   |
| 🧩 **AppDomain**                  | Isolated runtime unit inside a process (deprecated in .NET Core)   |

---
