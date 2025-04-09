[Advanced C#]
┌──────────────────────────────────────────────────────────────────────────────┐
│                       🔷 1️⃣ Define Delegate Type                            │
├──────────────────────────────────────────────────────────────────────────────┤
│ ✅ What: Declares a delegate type to match method signature                 │
│ 💡 Code:                                                                    │
│     public delegate void Notify();                                          │
│ 📌 Purpose: Defines a contract for methods taking no params, returning void │
│ 🧠 Internals: Generates class inheriting System.MulticastDelegate           │
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

Events
Generics
Reflection, Attributes and Metadata
Dynamic Binding
Disposal and Garbage Collection
Serialization
Application Domains
Lambda
Threading
Asynchronous Programming
Parallel Programming
Concurrency & Asynchrony
Native and COM Interoperability
Security
Networking
Streams and I/O
Diagnostics and Code Contracts
Performance Counter


```mermaid
flowchart TD
    A[Define Delegate Type] --> B[Create Delegate Instance]
    B --> C1[Store Method (Single)]
    B --> C2[Add Method (+=)]
    C1 --> D[Invoke() Executes Targets]
    C2 --> D
    D --> E[Method(s) Get Executed]
