```
┌──────────────────────────────────────────────────────────────────────────────┐
│                            1️⃣ 📦 Development & Build Phase                  │
├──────────────────────────────────────────────────────────────────────────────┤
│ 1. Developer writes C# code                                                  │
│    ├─ 🔰 Initiated by: Developer in IDE (e.g., Visual Studio, Rider)         │
│    └─ Authored in .cs files using .NET SDK                                   │
│    ├─ 🔶 CTS enforced                                                        │
│    │    → Ensures type safety across all .NET languages                      │
│    │         → What it is:                                                   │
│    │           1. CTS (Common Type System) defines a standard for data types │
│    │              and operations in .NET.                                    │
│    │         → What it does:                                                 │
│    │           1. Ensures all .NET languages share a common type system.     │
│    │           2. Validates type safety at runtime.                          │
│    │         → Why it does:                                                  │
│    │           1. To enable seamless interoperability between .NET languages.│
│    │           2. To ensure consistent behavior across the .NET ecosystem.   │
│    └─ 📜 CLS ensured                                                         │
│         → Enables cross-language compatibility of public APIs                │
│         → What it is:                                                        │
│           1. CLS (Common Language Specification) is a subset of CTS.         │
│           2. It defines rules for creating language-agnostic public APIs.    │
│         → What it does:                                                      │
│           1. Ensures public APIs are accessible across all .NET languages.   │
│           2. Enforces naming conventions and type usage for compatibility.   │
│         → Why it does:                                                       │
│           1. To allow developers to create reusable libraries.               │
│           2. To ensure interoperability between different .NET languages.    │
│                                                                              │
│ 2. MSBuild starts the build process                                          │
│    ├─ 🔰 Triggered by: Build command (CLI or IDE)                            │
│    └─ Parses .csproj files, resolves dependencies                            │
│    └─ Builds targets and project configurations                              │
│         → What it is:                                                        │
│           1. MSBuild is the build engine for .NET projects.                  │
│           2. It processes project files (.csproj) to orchestrate builds.    │
│         → What it does:                                                      │
│           1. Resolves project dependencies and NuGet packages.              │
│           2. Compiles source code into Intermediate Language (IL).          │
│           3. Generates output files (DLLs/EXEs).                             │                    │
│         → Why it does:                                                       │
│           1. To automate the build process for .NET applications.            │
│           2. To ensure consistent builds across environments.                │
│           3. To manage complex build pipelines with dependencies.            │
│                                                                              │
│ 3. Roslyn compiles C# to Intermediate Language (IL)                          │
│    ├─ 🔰 Triggered by: MSBuild invoking C# compiler                          │
│    ├─ ✅ Syntax & type checks performed                                      │
│    ├─ 📦 Type Checker enforces language-level type rules (CLR)              │
│    └─ IL + metadata emitted                                                  │
│         → What it is:                                                        │
│           1. Roslyn is the open-source compiler for C# and VB.NET.           │
│           2. It provides APIs for code analysis and compilation.             │
│         → What it does:                                                      │
│           1. Converts C# source code into Intermediate Language (IL).        │
│           2. Performs syntax and semantic analysis during compilation.       │
│         → Why it does:                                                       │
│           1. To ensure code correctness and enforce language rules.          │
│           2. To generate IL for execution on the .NET runtime.               │
│                                                                              │
│ 4. IL + metadata saved in PE files (DLLs/EXEs)                               │
│    ├─ 🔰 Triggered by: Roslyn compiler output                                │
│    └─ Portable Executable format stores assemblies                           │
│    └─ Metadata includes types, tokens, methods, etc.                         │
│                                                                              │
│ 5. NuGet packages resolved                                                   │
│    ├─ 🔰 Triggered by: MSBuild dependency resolution                         │
│    ├─ External dependencies restored                                         │
│    ├─ Dependency graph built                                                 │
│    └─ .deps.json & runtimeconfig.json generated                              │
└──────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────────────────────────────────────────────────────┐
│                         2️⃣ ⚙️ Application Hosting Layer                     │
├──────────────────────────────────────────────────────────────────────────────┤
│ 6. App launched via dotnet CLI or executable                                 │
│    ├─ 🔰 Initiated by: User runs dotnet CLI / application EXE                │
│    ├─ HostFXR loads runtime version                                          │
│         → What it is:                                                        │
│           1. HostFXR is the host resolver for .NET applications.             │
│           2. It determines the appropriate runtime version to load.          │
│         → What it does:                                                      │
│           1. Loads the correct .NET runtime version for the application.     │
│           2. Manages runtime configuration and dependency resolution.        │
│         → Why it does:                                                       │
│           1. To ensure the application runs on the correct runtime version.  │
│           2. To provide flexibility in runtime versioning and updates.       │
│    └─ HostPolicy locates and configures runtime                              │
│         → What it is:                                                        │
│           1. HostPolicy is the runtime configuration manager.                │
│           2. It is responsible for loading and initializing the runtime.     │
│         → What it does:                                                      │
│           1. Locates the runtime and application dependencies.               │
│           2. Configures runtime settings and prepares the runtime for use.   │
│         → Why it does:                                                       │
│           1. To ensure the runtime is properly configured for execution.     │
│           2. To handle runtime-specific settings and optimizations.          │
│                                                                              │
│ 7. CoreCLR runtime loaded                                                    │
│    ├─ 🔰 Triggered by: HostFXR/HostPolicy                                    │
│    ├─ 🧠 CLR initializes components:                                          │
│    │   ├─ 📚 Base Class Library support (System.*, etc.)                     │
│    │   ├─ 🧵 Thread support (ThreadPool, Tasks, async)                       │
│    │   ├─ 🔌 COM Marshaler (Interop services)                                │
│    │   ├─ 🔒 Security Engine (CAS, Permissions)                              │
│    │   ├─ 🐞 Debug Engine (Symbols, breakpoints)                             │
│    │   ├─ ⚙️ Code Manager (JIT method mgmt & stubs)                          │
│    │   ├─ 🔄 IL Compilers (JIT, Tiered Compilation)                          │
│    │   ├─ 🧹 Garbage Collector (Gen0/1/2, LOH)                                │
│    │   └─ 📦 Class Loader (AssemblyLoadContext, Reflection)                 │
│    ├─ AssemblyLoadContext created                                            │
│    └─ P/Invoke loads native libraries (OpenSSL/SChannel)                     │
│                                                                              │
│ 8. Program.cs runs                                                           │
│    ├─ 🔰 Triggered by: CoreCLR entry point execution                         │
│    ├─ Entry point initializes host                                           │
│    └─ CreateHostBuilder() sets up DI container                               │
│         → What it does:                                                      │
│           1. Configures the application host.                                │
│           2. Sets up dependency injection (DI) container.                   │
│           3. Configures logging and configuration sources.                   │
│           4. Registers services and middleware required for the app.         │
│         → Why it is used:                                                    │
│           1. To centralize application configuration and setup.              │
│           2. To ensure a consistent hosting environment.                     │
│           3. To enable modular and testable application design.              │
│         → Who triggers it:                                                   │
│           1. Triggered by the `Main` method in `Program.cs`.                 │
│           2. Invoked as part of the application startup process.             │
│                                                                              │
│ 9. Startup.cs runs                                                           │
│    ├─ 🔰 Triggered by: WebHost/GenericHost initialization                    │
│    ├─ ConfigureServices() builds DI container                                │
│    ├─ 🔶 CTS ensures typed registrations                                     │
│    │    → Guarantees strict type checking in DI services                     │
│    ├─ 📜 CLS ensures interoperable contracts                                 │
│    │    → Allows public service APIs to work across .NET languages           │
│    └─ Configure() registers middleware                                       │
│                                                                              │
│10. Middleware pipeline built                                                 │
│    ├─ 🔰 Triggered by: Startup.Configure execution                           │
│    └─ Delegates compiled via JIT                                             │
│         → What it is:                                                        │
│           1. Middleware is a component that processes HTTP requests/responses│
│              in a pipeline.                                                  │
│           2. It is executed sequentially as part of the request lifecycle.   │
│         → What it does:                                                      │
│           1. Handles cross-cutting concerns like logging, authentication,    │
│              and exception handling.                                         │
│           2. Passes control to the next middleware or generates a response.  │
│         → Why it does:                                                       │
│           1. To modularize and centralize common application logic.          │
│           2. To enable flexible and extensible request/response processing.  │
│         → Middleware Execution Order Example:                                │
│           ┌─────────────────────────────────────────────────┐                │
│           │           REQUEST PIPELINE FLOW                  │                │
│           │                    ↓                            │                │
│           │ 1. ExceptionHandler (Catches all exceptions)    │                │
│           │                    ↓                            │                │
│           │ 2. HttpsRedirection (HTTP → HTTPS)              │                │
│           │                    ↓                            │                │
│           │ 3. StaticFiles (Serves static content)         │                │
│           │                    ↓                            │                │
│           │ 4. Routing (Determines endpoint)               │                │
│           │                    ↓                            │                │
│           │ 5. Authentication (Identifies user)            │                │
│           │                    ↓                            │                │
│           │ 6. Authorization (Checks permissions)          │                │
│           │                    ↓                            │                │
│           │ 7. Endpoints (Executes controller/page)        │                │
│           │                    ↓                            │                │
│           │              RESPONSE FLOW                      │                │
│           │                    ↑                            │                │
│           │ 7. Endpoints (Post-processing)                 │                │
│           │                    ↑                            │                │
│           │ 6. Authorization (Post-processing)             │                │
│           │                    ↑                            │                │
│           │ 5. Authentication (Post-processing)            │                │
│           │                    ↑                            │                │
│           │ 4. Routing (Post-processing)                  │                │
│           │                    ↑                            │                │
│           │ 3. StaticFiles (Post-processing)              │                │
│           │                    ↑                            │                │
│           │ 2. HttpsRedirection (Post-processing)         │                │
│           │                    ↑                            │                │
│           │ 1. ExceptionHandler (Final error handling)    │                │
│           └─────────────────────────────────────────────────┘                │
│                                                                              │
│         → Important Notes:                                                   │
│           1. Order matters: Middleware executes in registration order        │
│           2. Bidirectional flow: Request ↓ then Response ↑                   │
│           3. Each middleware can:                                            │
│              • Process the request before next middleware                    │
│              • Process the response after next middleware                    │
│              • Short-circuit the pipeline at any point                       │
│           4. ExceptionHandler should be first to catch all errors            │
│           5. Authentication before Authorization always                      │
│           6. Endpoints middleware should be last                             │
└──────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────────────────────────────────────────────────────┐
│                 3️⃣ 🌐 HTTP Request Lifecycle (ASP.NET Core)                 │
├──────────────────────────────────────────────────────────────────────────────┤
│11. Kestrel starts HTTP listener                                              │
│    ├─ 🔰 Triggered by: Host.RunAsync()                                       │
│    ├─ Binds to TCP port (IOCP/epoll/kqueue)                                  │
│    └─ TLS handshake (OpenSSL/SChannel)                                       │
│         → What it is:                                                        │
│           1. Kestrel is a cross-platform, high-performance HTTP server for   │
│              ASP.NET Core applications.                                      │
│           2. It is the default web server used in ASP.NET Core.              │
│         → What it does:                                                      │
│           1. Listens for incoming HTTP requests on specified TCP ports.      │
│           2. Handles HTTP/HTTPS connections, including TLS termination.      │
│         → Why it does:                                                       │
│           1. To provide a lightweight, efficient, and scalable web server.   │
│           2. To enable hosting of ASP.NET Core applications on any platform. │
│                                                                              │
│12. Incoming request hits TCP socket                                          │
│    ├─ 🔰 Triggered by: External HTTP client request                          │
│    └─ OS handles with IOCP/epoll/kqueue                                      │
│                                                                              │
│13. ThreadPool schedules work item                                            │
│    ├─ 🔰 Triggered by: OS socket signal via Kestrel                          │
│    ├─ CLR Thread support activates thread queue                              │
│    └─ Work-stealing and CPU-aware scheduling                                 │
│                                                                              │
│14. Kestrel parses HTTP headers/body                                          │
│    ├─ 🔰 Triggered by: Request buffer ready for parsing                      │
│    ├─ Efficient parsing using Span<T>, Utf8Parser                            │
│    └─ Uses System.IO.Pipelines                                               │
│                                                                              │
│15. Request passed to ASP.NET Core runtime                                    │
│    ├─ 🔰 Triggered by: Kestrel forwarding HTTP context                       │
│    ├─ 🎭 Request Processing Orchestrator:                                    │
│    │    ├─ HttpContext created and initialized first                         │
│    │    ├─ ApplicationBuilder manages middleware registration                │
│    │    ├─ RequestDelegate factory builds pipeline                          │
│    │    └─ EndpointRoutingMiddleware runs early in pipeline                 │
│    └─ Control transferred to middleware pipeline                             │
│                                                                              │
│16. Middleware pipeline begins                                                │
│    ├─ 🔰 Triggered by: ASP.NET Core runtime                                  │
│    ├─ Request Delegate Chain Management:                                     │
│    │    ├─ RequestDelegate = async (context) => { ... }                     │
│    │    ├─ Each middleware maintains its own next delegate                   │
│    │    └─ Request Delegate Chain Explained:                                 │
│    │       → What it is:                                                     │
│    │          • A series of connected middleware components                  │
│    │          • Each component is a RequestDelegate function                 │
│    │          • Chain forms a pipeline of request processing                 │
│    │                                                                         │
│    │       → How it works:                                                   │
│    │          1. Each middleware is a delegate function:                     │
│    │             ```csharp                                                   │
│    │             public delegate Task RequestDelegate(HttpContext context);   │
│    │             ```                                                         │
│    │          2. Middleware registration creates chain:                      │
│    │             ```csharp                                                   │
│    │             app.Use(async (context, next) =>                           │
│    │             {                                                           │
│    │                 // Do something before next middleware                  │
│    │                 await next(context);                                    │
│    │                 // Do something after next middleware                   │
│    │             });                                                         │
│    │             ```                                                         │
│    │          3. Each middleware holds reference to next:                    │
│    │             • Middleware1 → Middleware2 → Middleware3 → etc             │
│    │                                                                         │
│    │       → Types of middleware connections:                                │
│    │          1. Use(): Allows continuation to next middleware               │
│    │             • Can process before and after next middleware              │
│    │             • Creates bidirectional pipeline                           │
│    │          2. Run(): Terminal middleware                                  │
│    │             • No next middleware called                                │
│    │             • Ends the pipeline                                        │
│    │                                                                         │
│    │       → Request flow through chain:                                     │
│    │          1. Request enters → Auth → Routing → Custom → Endpoint         │
│    │          2. Response returns ← Auth ← Routing ← Custom ← Endpoint       │
│    │          3. Each middleware can:                                        │
│    │             • Modify request/response                                   │
│    │             • Short-circuit the chain                                   │
│    │             • Add services/features                                     │
│    │       → Code Example:                                                   │
│    │             csharp                                                     │
│    │          app.Use(async (context, next) =>                              │
│    │          {                                                             │
│    │              // Check some condition                                    │
│    │              if (!context.User.Identity.IsAuthenticated)                │
│    │              {                                                          │
│    │                  // Short-circuit: Return response without calling next │
│    │                  context.Response.StatusCode = 401;                     │
│    │                  await context.Response.WriteAsync("Unauthorized");     │
│    │                  return; // Pipeline stops here                         │
│    │              }                                                          │
│    │                                                                         │
│    │              // Continue to next middleware if authenticated            │
│    │              await next();                                             │
│    │          });                                                           │
│    │                                                                        │
│    │       → Real-world scenarios:                                          │
│    │          1. Authentication:                                            │
│    │             • Blocks unauthorized requests immediately                  │
│    │             • Returns 401/403 without processing further               │
│    │          2. Caching:                                                   │
│    │             • Returns cached response if available                     │
│    │             • Skips entire controller execution                        │
│    │          3. Rate Limiting:                                             │
│    │             • Returns 429 Too Many Requests                            │
│    │             • Prevents excessive API usage                             │
│    │          4. API Versioning:                                            │
│    │             • Returns 400 for unsupported versions                     │
│    │             • Stops invalid requests early                             │
│    │                                                                         │
│    │       → Benefits of short-circuiting:                                  │
│    │          1. Performance:                                               │
│    │             • Avoids unnecessary processing                            │
│    │             • Reduces server load                                      │
│    │          2. Security:                                                  │
│    │             • Stops unauthorized access early                          │
│    │             • Prevents unnecessary exposure                            │
│    │          3. Resource Management:                                       │
│    │             • Controls API usage                                       │
│    │             • Optimizes server resources                               │
│    │                                                                         │
│    │       → Best Practices:                                                │
│    │          1. Short-circuit as early as possible                         │
│    │          2. Set appropriate status codes                               │
│    │          3. Include meaningful response messages                        │
│    │          4. Log short-circuit decisions                                │
│    ├─ Logging, Exception Handling, Auth, etc.                                │
│    ├─ Request Delegate Chain:                                                │
│    │    ┌─────────┐    ┌─────────┐    ┌─────────┐    ┌─────────┐          │
│    │    │ Auth    │    │ Routing │    │ Custom  │    │ Endpoint│          │
│    │ ───►Middlewar├───►│Middlewar├───►│Middlewar├───►│Middlewar├──►       │
│    │    │    e    │    │    e    │    │    e    │    │    e    │          │
│    │    └────┬────┘    └────┬────┘    └────┬────┘    └────┬────┘          │
│    │         │              │              │              │                 │
│    │         └──────────────┴──────────────┴──────────────┘                │
│    │                     Response Flow                                      │
│    └─ CLR Exception Manager monitors all errors                              │
│                                                                              │
│17. Routing Middleware identifies endpoint                                    │
│    ├─ 🔰 Triggered by: Middleware pipeline                                   │
│    └─ Maps request to appropriate controller/action                          │
│                                                                              │
│18. Endpoint attributes validated ([HttpGet], etc.)                           │
│    ├─ 🔰 Triggered by: Routing result                                        │
│    └─ Ensures correct routing annotations                                    │
│                                                                              │
│19. Filters executed (Auth, Resource, Action, Exception)                      │
│    ├─ 🔰 Triggered by: Endpoint invocation                                   │
│    ├─ Correct execution order:                                               │
│    │    1. Authorization filters                                             │
│    │       → Validates user permissions and authentication status            │
│    │    2. Resource filters                                                  │
│    │       → Handles caching and request short-circuiting before model bind  │
│    │       → What it does:                                                   │
│    │          1. Can short-circuit request before model binding              │
│    │          2. Implements output caching & response caching                │
│    │          3. Bypasses entire action pipeline if cache hit               │
│    │          4. Performance optimization for repeated requests              │
│    │          5. Can modify or wrap the action filter pipeline              │
│    │       → Examples:                                                       │
│    │          • [ResponseCache] attribute                                    │
│    │          • Custom cache implementations                                 │
│    │          • Resource sharing or rate limiting                            │
│    │    3. Action filters (before)                                           │
│    │       → Pre-processes request, can modify model/context before action   │
│    │    4. Model binding                                                     │
│    │       → Maps HTTP request data to action method parameters              │
│    │    5. Action execution                                                  │
│    │       → Runs the actual controller action method                        │
│    │    6. Action filters (after)                                            │
│    │       → Post-processes result, can modify action result before return   │
│    │    7. Result filters                                                    │
│    │       → Wraps result execution, can transform the final output          │
│    │    8. Exception filters (if needed)                                     │
│    │       → Handles any errors thrown during the pipeline execution         │
│    └─ CLR Exception Manager + Debug Engine intercepts faults                 │
│                                                                              │
│20. Model Binding & Validation                                                │
│    ├─ 🔰 Triggered by: Controller parameter resolution                       │
│    ├─ Binds request to parameters using Expression Trees                     │
│    ├─ 🔶 CTS: Type-checked binding                                           │
│    │    → Validates model data types during binding                          │
│    └─ ✅ Input validation enforced                                           │
│                                                                              │
│21. DI injects Controller + Dependencies                                      │
│    ├─ 🔰 Triggered by: ASP.NET Core ActivatorUtilities                       │
│    ├─ Constructor injection with services                                    │
│    ├─ 🔶 CTS compliance ensured                                              │
│    │    → Ensures type-safe object injection                                 │
│    └─ 📜 CLS compliance ensured                                              │
│         → Services are compatible across .NET languages                      │
│                                                                              │
│22. Controller method is invoked                                              │
│    ├─ 🔰 Triggered by: MVC/Routing invoking matched action                   │
│    ├─ 🟢 CLR: JIT (IL Compilers) compiles method to native                   │
│    └─ CLR handles GC, exceptions, async support                              │
│                                                                              │
│22.1 🧮 Code executed by CLR                                                  │
│    ├─ 🔰 Triggered by: JIT-compiled native method execution                  │
│    ├─ Executed on physical CPU by CLR via native instructions               │
│    └─ CLR handles stack frames, exceptions, garbage collection               │
│                                                                              │
│23. Controller → Service → Repository                                         │
│    ├─ 🔰 Triggered by: Application logic                                     │
│    ├─ Async/await or ValueTask<T> flows                                      │
│    └─ CLR coordinates continuation tasks                                     │
│                                                                              │
│23.1 🧮 Application logic executed by CLR                                     │
│    ├─ 🔰 Triggered by: Service/Repository IL compiled by JIT                │
│    └─ CPU executes logic via CLR runtime                                    │
│                                                                              │
│24. Data returned up to Controller                                            │
│    ├─ 🔰 Triggered by: Awaited async calls completing                        │
│    └─ Propagated up the call stack                                           │
└──────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────────────────────────────────────────────────────┐
│             4️⃣ 🎨 Optional: View Rendering (MVC / Razor)                    │
├──────────────────────────────────────────────────────────────────────────────┤
│25. Razor View selected (e.g., Index.cshtml)                                  │
│    ├─ 🔰 Triggered by: Controller returns a ViewResult                       │
│    ├─ View compiled: C# → IL → JIT’d native (on first access)                │
│    ├─ 🔶 CTS enforced in view code                                           │
│    │    → Ensures type-safe Razor components                                 │
│    ├─ 📜 CLS enforced in view code                                           │
│    │    → Ensures views are language-agnostic                                │
│    └─ HTML encoding applied (XSS protection)                                 │
│                                                                              │
│26. View generates HTML string                                                │
│    ├─ 🔰 Triggered by: Razor engine rendering                                │
│    └─ Returned as part of controller action result                           │
└──────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────────────────────────────────────────────────────┐
│                 5️⃣ 📤 Response Handling & Post-Processing                   │
├──────────────────────────────────────────────────────────────────────────────┤
│27. Action Result returned (View, JSON, File, etc.)                           │
│    ├─ 🔰 Triggered by: Controller completes execution                        │
│    └─ Final output passed to response pipeline                               │
│                                                                              │
│28. Result Filters (post-processing logic) run                                │
│    ├─ 🔰 Triggered by: ASP.NET Core action result pipeline                   │
│    └─ Final transformations (e.g., formatting)                               │
│                                                                              │
│29. Middleware post-processing                                                │
│    ├─ 🔰 Triggered by: Response moving back up middleware                    │
│    ├─ Logging, Compression, Exception wrapping                               │
│    └─ CLR ensures error handling completed                                   │
│                                                                              │
│30. Response serialized (e.g., JSON via Utf8JsonWriter)                       │
│    ├─ 🔰 Triggered by: Formatter middleware / endpoint logic                 │
│    └─ Headers, content length, content-type set                              │
│                                                                              │
│31. Written to HTTP stream                                                    │
│    ├─ 🔰 Triggered by: ASP.NET Core response writer                          │
│    └─ Copied to SocketAsyncEventArgs buffer                                  │
│                                                                              │
│32. Kestrel sends HTTP response                                               │
│    ├─ 🔰 Triggered by: Stream write completed                                │
│    └─ TCP packets transmitted via OS stack                                   │
│                                                                              │
│33. TCP response reaches client                                               │
│    └─ 🔰 Triggered by: Network layer delivery                                │
│    └─ Client receives final HTTP response                                    │
└──────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────────────────────────────────────────────────────┐
│                    6️⃣ 🧠 Deep CLR / OS-Level Operations                     │
├──────────────────────────────────────────────────────────────────────────────┤
│ CLR Responsibilities:                                                        │
│ ├─ 🔰 Triggered by: App execution and runtime needs                         │
│ ├─ 📚 Base Class Library support                                             │
│ ├─ 🧵 Thread support (ThreadPool, Tasks, async)                              │
│ ├─ 🔌 COM Marshaler for interop                                              │
│ ├─ 🛡️ Security Engine (CAS, role-based access)                             │
│ ├─ 🐞 Debug Engine (debug symbols, exception diagnostics)                    │
│ ├─ ⚙️ Code Manager (JIT mapping, method body mgmt)                          │
│ ├─ 🔄 IL Compilers (JIT/Tiered Compilation)                                  │
│ ├─ 🧹 Garbage Collector (Generational GC, LOH)                               │
│ └─ 📦 Class Loader (AssemblyLoadContext, Reflection)                        │
│                                                                              │
│ 🔶 CTS (Common Type System):                                                 │
│ ├─ Ensures runtime type safety                                               │
│ └─ All values validated by type contract                                     │
│                                                                              │
│ 📜 CLS (Common Language Specification):                                      │
│ ├─ Guarantees cross-language API exposure                                    │
│ └─ Public APIs usable across .NET languages                                  │
│                                                                              │
│ OS Responsibilities:                                                         │
│ ├─ 🔰 Triggered by: Hardware + app/kernel interactions                       │
│ ├─ Thread Scheduling, File I/O, Paging, DNS                                  │
│ ├─ I/O Completion Ports / epoll / kqueue                                     │
│ └─ TLS Termination (OpenSSL, SChannel, Apple TLS)                            │
└──────────────────────────────────────────────────────────────────────────────┘
```
