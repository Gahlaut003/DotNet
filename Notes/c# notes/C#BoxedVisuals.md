┌──────────────────────────────────────────────────────────────────────────────┐
│                             🔹 What is a Delegate?                           │
├──────────────────────────────────────────────────────────────────────────────┤
│ ✅ Definition                                                                │
│    └─ A type-safe object that holds a reference to a method.                │
│    └─ Acts like a function pointer, enabling dynamic method calls.          │
│    └─ Can reference one or more methods at runtime.                         │
│                                                                              │
│ 🔖 Official Definition (Microsoft):                                         │
│ "A delegate is a type that represents references to methods with a          │
│ particular parameter list and return type."                                 │
└──────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────────────────────────────────────────────────────┐
│                 🎯 Why We Use Delegates - Benefits & Scenarios               │
├──────────────────────────────────────────────────────────────────────────────┤
│ 🔁 1. Decoupling Callers from Implementations                                │
│    └─ Pass logic as parameters to decouple logic from execution.            │
│    └─ Enables dynamic behavior injection.                                   │
│                                                                              │
│ 🧩 2. Events and Callbacks                                                   │
│    └─ Core mechanism behind C# events.                                       │
│    └─ Useful for notification and reactive programming.                      │
│                                                                              │
│ ⏱️ 3. Asynchronous Programming                                               │
│    └─ Supports async patterns via BeginInvoke or async/await.               │
│    └─ Enables non-blocking background execution.                            │
│                                                                              │
│ 🧩 4. Extensibility & Flexibility (LINQ/UI/etc.)                             │
│    └─ Allows injecting logic dynamically using Func<>/Action<>.             │
│    └─ Powers LINQ, UI event handlers, and strategy patterns.                │
│                                                                              │
│ 🔁 5. Multicast Behaviors                                                    │
│    └─ One delegate can invoke multiple methods via +=.                      │
│    └─ Used in broadcasting notifications.                                   │
└──────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────────────────────────────────────────────────────┐
│                        ❓ What Problem It Solves                              │
├──────────────────────────────────────────────────────────────────────────────┤
│ 🚫 1. Avoids Hardcoded Method Calls                                          │
│    └─ Replace static calls with passed-in logic.                            │
│                                                                              │
│ 🧩 2. Enables Plug-and-Play Behavior Injection                               │
│    └─ Behavior can be altered at runtime via delegates.                     │
│                                                                              │
│ 🔁 3. Promotes Inversion of Control (IoC)                                    │
│    └─ Lets the callee choose the action to perform.                         │
│                                                                              │
│ 📦 4. Encapsulated, Reusable Invocation Logic                                │
│    └─ Delegates can be passed across layers/modules for reuse.              │
└──────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────────────────────────────────────────────────────┐
│                        🔑 Additional Key Points                              │
├──────────────────────────────────────────────────────────────────────────────┤
│ 🔧 1. Generics with Delegates                                                │
│    └─ Enables reusable, type-safe delegate definitions.                     │
│    └─ Common: Func<>, Action<>, Predicate<>.                                │
│    └─ Compile-time safety and simplified syntax.                            │
│                                                                              │
│ 🌀 2. Functional Programming Foundations                                      │
│    └─ Delegates enable higher-order functions and immutability.            │
│    └─ Core for LINQ, declarative style, lambdas.                            │
│                                                                              │
│ ⚖️ 3. Comparison with Interfaces                                             │
│    └─ Delegate: One-method, concise behavior passing.                       │
│    └─ Interface: Multi-method contract across implementations.              │
│                                                                              │
│ 🔗 4. Chaining and Invocation List                                           │
│    └─ Delegates store method lists, invoked in order.                       │
│    └─ Can inspect list via GetInvocationList().                             │
│                                                                              │
│ 🛠️ 5. Delegates vs Lambda Expressions                                        │
│    └─ Lambda: Syntactic sugar over delegates.                               │
│    └─ Enables inline, concise anonymous methods.                            │
└──────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────────────────────────────────────────────────────┐
│                     🔍 Types of Delegates in C#                              │
├──────────────────────────────────────────────────────────────────────────────┤
│ 1️⃣ Single-Cast Delegate                                                     │
│    └─ Points to a single method. Used for isolated tasks.                   │
│                                                                              │
│ 2️⃣ Multi-Cast Delegate                                                      │
│    └─ Points to multiple methods (+=). All invoked in order.                │
│                                                                              │
│ 3️⃣ Generic Delegates                                                        │
│    └─ Func<>, Action<>, Predicate<> are built-in generics.                  │
│    └─ Used heavily in LINQ and async code.                                  │
│                                                                              │
│ 4️⃣ Anonymous Delegates                                                      │
│    └─ Inline methods using the `delegate` keyword.                          │
│    └─ Good for one-time short logic.                                        │
│                                                                              │
│ 5️⃣ Lambda Expressions                                                       │
│    └─ Inline, shorthand syntax using `=>`.                                  │
│    └─ Widely used with LINQ, events, async code.                            │
│                                                                              │
│ 6️⃣ Custom Delegates                                                         │
│    └─ User-defined method signature delegates.                              │
│    └─ Used when built-in types don’t fit.                                   │
└──────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────────────────────────────────────────────────────┐
│                       🔷 1️⃣ Define Delegate Type                            │
├──────────────────────────────────────────────────────────────────────────────┤
│ ✅ What: Declares a delegate type to match method signature                 │
│ 💡 Code:                                                                    │
│     public delegate void Notify();                                          │
│ 📌 Purpose: Defines a contract for methods taking no params, returning void │
│ 🧠 Internals: Generates class inheriting System.MulticastDelegate           │
│                                                                              │
│ 🔖 Official Definition (Microsoft):                                         │
│ "A delegate is a type that safely encapsulates a method, similar to a       │
│ function pointer in C and C++."                                             │
└────────────┬─────────────────────────────────────────────────────────────────┘
             ↓
┌──────────────────────────────────────────────────────────────────────────────┐
│                       🔷 2️⃣ Create Delegate Instance                         │
├──────────────────────────────────────────────────────────────────────────────┤
│ ✅ What: Create an instance by assigning a method to the delegate           │
│ 💡 Code:                                                                    │
│     void ShowMessage() => Console.WriteLine("Hello from Delegate!");        │
│     Notify notify = ShowMessage;                                            │
│ 📌 Purpose: Binds delegate to `ShowMessage` method                          │
│ 🧠 Internals: Delegate now holds reference to method pointer                │
└────────────┬─────────────────────────────────────────────────────────────────┘
             ↓
┌──────────────────────────────────────────────────────────────────────────────┐
│                    🔷 3️⃣ Store Method (Single-cast)                         │
├──────────────────────────────────────────────────────────────────────────────┤
│ ✅ What: Stores one method reference in the delegate                        │
│ 💡 Code:                                                                    │
│     notify(); // Outputs: Hello from Delegate!                             │
│ 📌 Purpose: Execute the bound method                                        │
│ 🧠 Internals: Calls method in invocation list with one entry               │
└────────────┬─────────────────────────────────────────────────────────────────┘
             ↓
┌──────────────────────────────────────────────────────────────────────────────┐
│                          🔷 4️⃣ Add Method (+=)                              │
├──────────────────────────────────────────────────────────────────────────────┤
│ ✅ What: Add multiple methods (Multicast Delegate)                          │
│ 💡 Code:                                                                    │
│     void LogMessage() => Console.WriteLine("Logging message...");           │
│     notify += LogMessage;                                                  │
│ 📌 Purpose: Multiple methods get invoked                                    │
│ 🧠 Internals: notify’s invocation list has 2 method entries                │
└────────────┬─────────────────────────────────────────────────────────────────┘
             ↓
┌──────────────────────────────────────────────────────────────────────────────┐
│                 🔷 5️⃣ Invoke() Executes Targets                             │
├──────────────────────────────────────────────────────────────────────────────┤
│ ✅ What: Executes all methods in delegate’s invocation list                 │
│ 💡 Code:                                                                    │
│     notify();                                                               │
│     // Output:                                                              │
│     // Hello from Delegate!                                                 │
│     // Logging message...                                                   │
│ 📌 Purpose: All methods execute in order of addition                        │
│ 🧠 Internals: Delegate sequentially calls each target in list              │
└────────────┬─────────────────────────────────────────────────────────────────┘
             ↓
┌──────────────────────────────────────────────────────────────────────────────┐
│                    🔷 6️⃣ Method(s) Get Executed                             │
├──────────────────────────────────────────────────────────────────────────────┤
│ ✅ What: Each method body runs with defined logic                           │
│ 💡 Code:                                                                    │
│     // ShowMessage prints to console                                       │
│     // LogMessage prints to console                                        │
│ 📌 Purpose: Action logic encapsulated in methods                           │
│ 🧠 Internals: Each method gets a new call stack frame                       │
└────────────┬─────────────────────────────────────────────────────────────────┘
             ↓
┌──────────────────────────────────────────────────────────────────────────────┐
│                         🧪 📦 Summary Code Block                             │
├──────────────────────────────────────────────────────────────────────────────┤
│ public delegate void Notify();                                              │
│                                                                              │
│ void ShowMessage() => Console.WriteLine("Hello from Delegate!");            │
│ void LogMessage() => Console.WriteLine("Logging message...");               │
│                                                                              │
│ Notify notify = ShowMessage; // Step 2                                      │
│ notify += LogMessage;           // Step 4                                    │
│                                                                              │
│ notify();                     // Step 5 invokes both methods                 │
│ // Output:                                                                   │
│ // Hello from Delegate!                                                     │
│ // Logging message...                                                       │
└──────────────────────────────────────────────────────────────────────────────┘


┌────────────────────────────────────────────┐
│     ❌ Tightly Coupled Implementation       │
├────────────────────────────────────────────┤
│ Processor directly calls Console log       │
│                                            │
│ class Processor                            │
│ {                                          │
│     public void Start()                    │
│     {                                      │
│         Console.WriteLine("Start...");     │
│         Console.WriteLine("End.");         │
│     }                                      │
│ }                                          │
└────────────────────────────────────────────┘
             │  Problem: Hard to change log mechanism
             ▼

┌────────────────────────────────────────────┐
│    ✅ Decoupled with Delegate Injection     │
├────────────────────────────────────────────┤
│ Processor receives delegate method          │
│                                            │
│ public delegate void LogHandler(string);   │
│                                            │
│ class Processor                            │
│ {                                          │
│     public void Start(LogHandler logger)   │
│     {                                      │
│         logger("Start...");                │
│         logger("End.");                    │
│     }                                      │
│ }                                          │
└────────────────────────────────────────────┘
             │  Flexibility: Plug different logging
             ▼

┌────────────────────────────────────────────┐
│     🔧 Swapable Delegate Implementations    │
├────────────────────────────────────────────┤
│ void LogToConsole(string msg)              │
│   => Console.WriteLine("Console: " + msg); │
│                                            │
│ void LogToFile(string msg)                 │
│   => File.AppendAllText("log.txt", msg);   │
│                                            │
│ Processor p = new Processor();             │
│ p.Start(LogToConsole);                     │
│ p.Start(LogToFile);                        │
└────────────────────────────────────────────┘
             │  Result: Same Processor, new behaviors!
             ▼

┌────────────────────────────────────────────┐
│      🎯 Benefits of Delegate Decoupling     │
├────────────────────────────────────────────┤
│ ✔ Reusable code – no logic hardcoded       │
│ ✔ Plug-and-play: pass any method at runtime│
│ ✔ Easy testing – mock methods easily       │
│ ✔ Core of event systems & extensibility    │
└────────────────────────────────────────────┘
