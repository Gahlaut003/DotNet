┌──────────────────────────────────────────────────────────────────────────────┐
│                                   🔹 EVENTS                                  │
├──────────────────────────────────────────────────────────────────────────────┤
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                             ✅ DEFINITION                                │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ A mechanism for communication between objects.                          │ │
│ │ Built on top of delegates, enabling the publish-subscribe pattern.      │ │
│ │ Allows one-to-many method invocation.                                   │ │
│ │                                                                          │ │
│ │ 🔖 Official Definition (Microsoft):                                     │ │
│ │ "An event is a message sent by an object to signal the occurrence of    │ │
│ │ an action. The action could be caused by user interaction, program      │ │
│ │ logic, or some other source."                                           │ │
│ └──────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                 🎯 WHY WE USE EVENTS - BENEFITS & SCENARIOS              │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 🔁 1. Decoupling Publishers and Subscribers                              │ │
│ │    └─ Publishers raise events without knowing subscribers.              │ │
│ │    └─ Subscribers handle events independently.                          │ │
│ │ 🧩 2. Notification Mechanism                                             │ │
│ │    └─ Core for UI frameworks, reactive programming, and notifications.  │ │
│ │    └─ Enables dynamic response to state changes.                        │ │
│ │ 🔗 3. Extensibility                                                      │ │
│ │    └─ Allows adding/removing handlers dynamically.                      │ │
│ │    └─ Promotes modular and reusable code.                               │ │
│ └──────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                        ❓ WHAT PROBLEM IT SOLVES                          │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 🚫 1. Avoids Tight Coupling                                              │ │
│ │    └─ Publishers don’t need to know about subscribers.                  │ │
│ │ 🧩 2. Enables Reactive Programming                                       │ │
│ │    └─ Objects can react to changes dynamically.                         │ │
│ │ 🔁 3. Promotes Inversion of Control (IoC)                                │ │
│ │    └─ Subscribers decide how to handle events.                          │ │
│ └──────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                       🔑 ADDITIONAL KEY POINTS                           │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 🔧 1. Events vs Delegates                                                │ │
│ │    └─ Events restrict direct invocation by external code.               │ │
│ │    └─ Delegates allow direct invocation.                                │ │
│ │ 🌀 2. Event Accessors                                                    │ │
│ │    └─ Add/remove handlers using `+=` and `-=`.                          │ │
│ │    └─ Custom accessors can be defined for advanced scenarios.           │ │
│ │ ⚖️ 3. Multicast Behavior                                                 │ │
│ │    └─ Events can have multiple subscribers.                             │ │
│ │    └─ All handlers are invoked in order of addition.                    │ │
│ └──────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                     🔍 TYPES OF EVENTS IN C#                             │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 1️⃣ Standard Events                                                     │ │
│ │    └─ Events declared using the `event` keyword and a delegate type.    │ │
│ │ 2️⃣ Custom Events                                                       │ │
│ │    └─ Events with custom add/remove accessors for advanced scenarios.   │ │
│ │ 3️⃣ Multicast Events                                                    │ │
│ │    └─ Events that allow multiple subscribers.                           │ │
│ │ 4️⃣ Static Events                                                       │ │
│ │    └─ Events declared as `static`, shared across all instances of a     │ │
│ │       class.                                                            │ │
│ │ 5️⃣ Generic Events                                                      │ │
│ │    └─ Events using generic delegate types like `EventHandler<T>`.       │ │
│ └──────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                       🔷 STEPS TO WORK WITH EVENTS                       │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 1️⃣ Declare an Event                                                    │ │
│ │    └─ `public event EventHandler MyEvent;`                              │ │
│ │ 2️⃣ Subscribe to an Event                                               │ │
│ │    └─ `MyEvent += HandlerMethod;`                                       │ │
│ │ 3️⃣ Raise an Event                                                      │ │
│ │    └─ `MyEvent?.Invoke(this, EventArgs.Empty);`                         │ │
│ │ 4️⃣ Unsubscribe from an Event                                           │ │
│ │    └─ `MyEvent -= HandlerMethod;`                                       │ │
│ └──────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                         🧪 📦 SUMMARY CODE BLOCK                         │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ public class Publisher                                                  │ │
│ │ {                                                                       │ │
│ │     public event EventHandler MyEvent;                                  │ │
│ │     public void RaiseEvent()                                            │ │
│ │     {                                                                   │ │
│ │         MyEvent?.Invoke(this, EventArgs.Empty);                         │ │
│ │     }                                                                   │ │
│ │ }                                                                       │ │
│ │ public class Subscriber                                                 │ │
│ │ {                                                                       │ │
│ │     public void OnEventRaised(object sender, EventArgs e)               │ │
│ │     {                                                                   │ │
│ │         Console.WriteLine("Event received!");                           │ │
│ │     }                                                                   │ │
│ │ }                                                                       │ │
│ │ Publisher publisher = new Publisher();                                  │ │
│ │ Subscriber subscriber = new Subscriber();                               │ │
│ │ publisher.MyEvent += subscriber.OnEventRaised;                          │ │
│ │ publisher.RaiseEvent();                                                 │ │
│ │ // Output: Event received!                                              │ │
│ └──────────────────────────────────────────────────────────────────────────┘ │
└──────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────────────────────────────────────────────────────┐
│                                   🔹 GENERICS                                │
├──────────────────────────────────────────────────────────────────────────────┤
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                             ✅ DEFINITION                                │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ Generics allow you to define type-safe data structures and methods       │ │
│ │ without committing to a specific data type.                              │ │
│ │                                                                          │ │
│ │ 🔖 Official Definition (Microsoft):                                     │ │
│ │ "Generics allow you to define a class, method, delegate, or interface   │ │
│ │ with a placeholder for the type of its data."                           │ │
│ └──────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                 🎯 WHY WE USE GENERICS - BENEFITS & SCENARIOS            │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 🔁 1. Type Safety                                                        │ │
│ │    └─ Prevents runtime type errors by enforcing compile-time checks.    │ │
│ │                                                                          │ │
│ │ 🧩 2. Code Reusability                                                   │ │
│ │    └─ Write once, use with multiple data types.                         │ │
│ │                                                                          │ │
│ │ 🔗 3. Performance                                                        │ │
│ │    └─ Avoids boxing/unboxing for value types.                           │ │
│ │                                                                          │ │
│ │ 🛠️ 4. Simplified Code                                                    │ │
│ │    └─ Reduces code duplication and improves maintainability.            │ │
│ │                                                                          │ │
│ │ 🔍 5. Flexibility                                                        │ │
│ │    └─ Works with collections, algorithms, and custom types.             │ │
│ └──────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                        ❓ WHAT PROBLEM IT SOLVES                          │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 🚫 1. Avoids Code Duplication                                            │ │
│ │    └─ Eliminates the need to write separate classes for each type.      │ │
│ │                                                                          │ │
│ │ 🧩 2. Prevents Runtime Errors                                             │ │
│ │    └─ Ensures type safety at compile time.                               │ │
│ │                                                                          │ │
│ │ 🔁 3. Improves Performance                                                │ │
│ │    └─ Avoids boxing/unboxing overhead for value types.                   │ │
│ └──────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                       🔑 ADDITIONAL KEY POINTS                           │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 🔧 1. Generic Constraints                                                │ │
│ │    └─ Restrict the types that can be used with generics (e.g., `where`). │ │
│ │                                                                          │ │
│ │ 🌀 2. Generic Collections                                                │ │
│ │    └─ Built-in collections like `List<T>`, `Dictionary<TKey, TValue>`.  │ │
│ │                                                                          │ │
│ │ ⚖️ 3. Comparison with Non-Generic Collections                            │ │
│ │    └─ Generics avoid type casting and improve performance.              │ │
│ │                                                                          │ │
│ │ 🔗 4. Generic Methods                                                    │ │
│ │    └─ Methods that operate on parameters of type `T`.                   │ │
│ │                                                                          │ │
│ │ 🛠️ 5. Generic Delegates                                                  │ │
│ │    └─ Delegates like `Func<T>`, `Action<T>` for type-safe callbacks.    │ │
│ └──────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                     🔍 TYPES OF GENERICS IN C#                           │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 1️⃣ Generic Classes                                                     │ │
│ │    └─ Classes with type parameters (e.g., `class MyClass<T>`).          │ │
│ │                                                                          │ │
│ │ 2️⃣ Generic Methods                                                     │ │
│ │    └─ Methods with type parameters (e.g., `void Print<T>(T value)`).    │ │
│ │                                                                          │ │
│ │ 3️⃣ Generic Interfaces                                                  │ │
│ │    └─ Interfaces with type parameters (e.g., `IEnumerable<T>`).         │ │
│ │                                                                          │ │
│ │ 4️⃣ Generic Delegates                                                   │ │
│ │    └─ Delegates with type parameters (e.g., `Func<T>`, `Action<T>`).    │ │
│ │                                                                          │ │
│ │ 5️⃣ Generic Constraints                                                 │ │
│ │    └─ Restrict types using `where` clause (e.g., `where T : class`).    │ │
│ └──────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                       🔷 STEPS TO WORK WITH GENERICS                     │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 1️⃣ Define a Generic Class                                              │ │
│ │    └─ `class MyClass<T> { public T Value; }`                            │ │
│ │                                                                          │ │
│ │ 2️⃣ Instantiate with a Specific Type                                    │ │
│ │    └─ `MyClass<int> obj = new MyClass<int>();`                          │ │
│ │                                                                          │ │
│ │ 3️⃣ Use Generic Methods                                                 │ │
│ │    └─ `void Print<T>(T value) { Console.WriteLine(value); }`            │ │
│ │                                                                          │ │
│ │ 4️⃣ Apply Constraints                                                   │ │
│ │    └─ `where T : class` or `where T : new()`                            │ │
│ │                                                                          │ │
│ │ 5️⃣ Use Built-in Generic Collections                                    │ │
│ │    └─ `List<int> numbers = new List<int>();`                            │ │
│ └──────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                         🧪 📦 SUMMARY CODE BLOCK                         │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ // Generic Class                                                         │ │
│ │ class MyClass<T>                                                         │ │
│ │ {                                                                        │ │
│ │     public T Value;                                                      │ │
│ │ }                                                                        │ │
│ │                                                                          │ │
│ │ // Generic Method                                                        │ │
│ │ void Print<T>(T value)                                                   │ │
│ │ {                                                                        │ │
│ │     Console.WriteLine(value);                                            │ │
│ │ }                                                                        │ │
│ │                                                                          │ │
│ │ // Usage                                                                 │ │
│ │ MyClass<int> obj = new MyClass<int>();                                   │ │
│ │ obj.Value = 42;                                                          │ │
│ │ Console.WriteLine(obj.Value); // Output: 42                              │ │
│ │                                                                          │ │
│ │ Print<string>("Hello Generics!"); // Output: Hello Generics!             │ │
│ └──────────────────────────────────────────────────────────────────────────┘ │
└──────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────────────────────────────────────────────────────┐
│                     🔹 REFLECTION, ATTRIBUTES AND METADATA                  │
├──────────────────────────────────────────────────────────────────────────────┤
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                             ✅ DEFINITION                                │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ Reflection provides objects that describe assemblies, modules, and types │ │
│ │ in your code. It allows runtime type discovery and dynamic invocation.   │ │
│ │                                                                          │ │
│ │ Attributes are metadata annotations added to code elements (classes,     │ │
│ │ methods, properties, etc.) to provide additional information.            │ │
│ │                                                                          │ │
│ │ Metadata is information about the structure of your code, stored in      │ │
│ │ assemblies, and used by the CLR for runtime operations.                  │ │
│ │                                                                          │ │
│ │ 🔖 Official Definition (Microsoft):                                     │ │
│ │ "Reflection provides objects that encapsulate assemblies, modules, and  │ │
│ │ types. Attributes provide a powerful way to add metadata to your code." │ │
│ └──────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │ 🎯 WHY WE USE REFLECTION, ATTRIBUTES AND METADATA - BENEFITS & SCENARIOS │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 🔁 1. Runtime Type Discovery                                             │ │
│ │    └─ Inspect types, methods, properties, and fields at runtime.        │ │
│ │                                                                          │ │
│ │ 🧩 2. Dynamic Invocation                                                 │ │
│ │    └─ Invoke methods or access properties dynamically.                  │ │
│ │                                                                          │ │
│ │ 🔗 3. Custom Attributes                                                  │ │
│ │    └─ Add metadata for custom logic (e.g., validation, serialization).  │ │
│ │                                                                          │ │
│ │ 🛠️ 4. Code Analysis and Debugging                                        │ │
│ │    └─ Analyze assemblies for tools like IDEs, debuggers, and profilers. │ │
│ │                                                                          │ │
│ │ 🔍 5. Dependency Injection                                               │ │
│ │    └─ Used in frameworks like ASP.NET Core for service resolution.      │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                        ❓ WHAT PROBLEM IT SOLVES                          │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 🚫 1. Avoids Hardcoding                                                  │ │
│ │    └─ Enables dynamic behavior without recompiling code.                │ │
│ │                                                                          │ │
│ │ 🧩 2. Enables Extensibility                                               │ │
│ │    └─ Add custom attributes for modular and reusable logic.             │ │
│ │                                                                          │ │
│ │ 🔁 3. Supports Frameworks and Tools                                       │ │
│ │    └─ Powers frameworks like Entity Framework, ASP.NET, and LINQ.       │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                       🔑 ADDITIONAL KEY POINTS                           │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 🔧 1. Reflection Performance                                              │ │
│ │    └─ Reflection is slower than direct code execution. Use cautiously.  │ │
│ │                                                                          │ │
│ │ 🌀 2. Custom Attributes                                                   │ │
│ │    └─ Define attributes by inheriting from `System.Attribute`.          │ │
│ │                                                                          │ │
│ │ ⚖️ 3. Metadata in Assemblies                                              │ │
│ │    └─ Metadata is stored in the assembly manifest.                      │ │
│ │                                                                          │ │
│ │ 🔗 4. Security Considerations                                             │ │
│ │    └─ Reflection can expose private members. Use with care.             │ │
│ │                                                                          │ │
│ │ 🛠️ 5. Reflection.Emit                                                     │ │
│ │    └─ Generate and execute code dynamically at runtime.                 │ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                     🔍 TYPES OF REFLECTION IN C#                         │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 1️⃣ Assembly Reflection                                                  │ │
│ │    └─ Inspect assemblies and their types.                               │ │
│ │                                                                          │ │
│ │ 2️⃣ Type Reflection                                                      │ │
│ │    └─ Inspect methods, properties, and fields of a type.                │ │
│ │                                                                          │ │
│ │ 3️⃣ Method Reflection                                                    │ │
│ │    └─ Invoke methods dynamically.                                       │ │
│ │                                                                          │ │
│ │ 4️⃣ Property Reflection                                                  │ │
│ │    └─ Get or set property values dynamically.                           │ │
│ │                                                                          │ │
│ │ 5️⃣ Custom Attribute Reflection                                          │ │
│ │    └─ Retrieve custom attributes applied to code elements.              │ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                       🔷 STEPS TO WORK WITH REFLECTION                   │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 1️⃣ Load an Assembly                                                    │ │
│ │    └─ `Assembly assembly = Assembly.Load("MyAssembly");`                │ │
│ │                                                                          │ │
│ │ 2️⃣ Get Types in Assembly                                               │ │
│ │    └─ `Type[] types = assembly.GetTypes();`                             │ │
│ │                                                                          │ │
│ │ 3️⃣ Inspect Members of a Type                                           │ │
│ │    └─ `MethodInfo[] methods = type.GetMethods();`                       │ │
│ │                                                                          │ │
│ │ 4️⃣ Invoke a Method Dynamically                                         │ │
│ │    └─ `method.Invoke(instance, parameters);`                            │ │
│ │                                                                          │ │
│ │ 5️⃣ Retrieve Custom Attributes                                          │ │
│ │    └─ `Attribute[] attrs = Attribute.GetCustomAttributes(type);`        │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                         🧪 📦 SUMMARY CODE BLOCK                         │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ using System;                                                            │ │
│ │ using System.Reflection;                                                 │ │
│ │                                                                          │ │
│ │ [AttributeUsage(AttributeTargets.Class)]                                 │ │
│ │ public class MyCustomAttribute : Attribute                              │ │
│ │ {                                                                        │ │
│ │     public string Description { get; set; }                              │ │
│ │ }                                                                        │ │
│ │                                                                          │ │
│ │ [MyCustomAttribute(Description = "Sample Class")]                        │ │
│ │ public class SampleClass                                                 │ │
│ │ {                                                                        │ │
│ │     public void Print() => Console.WriteLine("Hello Reflection!");       │ │
│ │ }                                                                        │ │
│ │                                                                          │ │
│ │ Assembly assembly = Assembly.GetExecutingAssembly();                     │ │
│ │ Type type = assembly.GetType("SampleClass");                             │ │
│ │ object instance = Activator.CreateInstance(type);                        │ │
│ │ MethodInfo method = type.GetMethod("Print");                             │ │
│ │ method.Invoke(instance, null);                                           │ │
│ │                                                                          │ │
│ │ // Output: Hello Reflection!                                             │ │
└──────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────────────────────────────────────────────────────┐
│                     🔹 DISPOSAL AND GARBAGE COLLECTION                      │
├──────────────────────────────────────────────────────────────────────────────┤
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                             ✅ DEFINITION                                │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ Disposal is the process of releasing unmanaged resources explicitly.     │ │
│ │ Garbage Collection (GC) is an automatic memory management feature in     │ │
│ │ .NET that reclaims unused managed objects.                               │ │
│ │                                                                          │ │
│ │ 🔖 Official Definition (Microsoft):                                     │ │
│ │ "Garbage Collection is the process of automatically reclaiming memory   │ │
│ │ occupied by objects that are no longer accessible."                     │ │
│ └──────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │ 🎯 WHY WE USE DISPOSAL AND GARBAGE COLLECTION - BENEFITS & SCENARIOS     │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 🔁 1. Automatic Memory Management                                        │ │
│ │    └─ Reduces developer effort by handling memory cleanup.              │ │
│ │                                                                          │ │
│ │ 🧩 2. Resource Optimization                                              │ │
│ │    └─ Frees unused memory, improving application performance.           │ │
│ │                                                                          │ │
│ │ 🔗 3. Explicit Resource Management                                       │ │
│ │    └─ `IDisposable` allows manual cleanup of unmanaged resources.       │ │
│ │                                                                          │ │
│ │ 🛠️ 4. Prevents Memory Leaks                                              │ │
│ │    └─ Ensures objects are properly disposed when no longer needed.      │ │
│ │                                                                          │ │
│ │ 🔍 5. Finalization for Unmanaged Resources                               │ │
│ │    └─ Finalizers (`~ClassName`) handle cleanup for unmanaged resources. │ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                        ❓ WHAT PROBLEM IT SOLVES                          │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 🚫 1. Prevents Resource Leaks                                            │ │
│ │    └─ Ensures proper cleanup of unmanaged resources like file handles.  │ │
│ │                                                                          │ │
│ │ 🧩 2. Simplifies Memory Management                                        │ │
│ │    └─ Automates memory allocation and deallocation.                     │ │
│ │                                                                          │ │
│ │ 🔁 3. Improves Application Stability                                      │ │
│ │    └─ Reduces crashes caused by memory exhaustion.                      │ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                       🔑 ADDITIONAL KEY POINTS                           │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 🔧 1. IDisposable Interface                                              │ │
│ │    └─ Implement `Dispose` method for explicit resource cleanup.         │ │
│ │                                                                          │ │
│ │ 🌀 2. Finalizers                                                         │ │
│ │    └─ Used for cleanup when `Dispose` is not called explicitly.         │ │
│ │                                                                          │ │
│ │ ⚖️ 3. GC Generations                                                     │ │
│ │    └─ Objects are categorized into Gen 0, Gen 1, and Gen 2 for GC.      │ │
│ │                                                                          │ │
│ │ 🔗 4. Suppress Finalization                                              │ │
│ │    └─ Use `GC.SuppressFinalize` to prevent redundant finalization.      │ │
│ │                                                                          │ │
│ │ 🛠️ 5. Weak References                                                    │ │
│ │    └─ Allow access to objects without preventing their collection.      │ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                     🔍 TYPES OF GARBAGE COLLECTION IN C#                 │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 1️⃣ Workstation GC                                                      │ │
│ │    └─ Optimized for single-threaded applications.                       │ │
│ │                                                                          │ │
│ │ 2️⃣ Server GC                                                           │ │
│ │    └─ Optimized for multi-threaded, high-performance applications.      │ │
│ │                                                                          │ │
│ │ 3️⃣ Concurrent GC                                                       │ │
│ │    └─ Runs alongside application threads to minimize pauses.            │ │
│ │                                                                          │ │
│ │ 4️⃣ Background GC                                                       │ │
│ │    └─ Improves performance by running in the background.                │ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                       🔷 STEPS TO WORK WITH DISPOSAL                     │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 1️⃣ Implement IDisposable Interface                                     │ │
│ │    └─ `public void Dispose() { /* Cleanup logic */ }`                   │ │
│ │                                                                          │ │
│ │ 2️⃣ Use `using` Statement                                               │ │
│ │    └─ `using (var resource = new Resource()) { /* Use resource */ }`    │ │
│ │                                                                          │ │
│ │ 3️⃣ Suppress Finalization                                               │ │
│ │    └─ `GC.SuppressFinalize(this);`                                      │ │
│ │                                                                          │ │
│ │ 4️⃣ Monitor GC Events                                                   │ │
│ │    └─ Use `GC.Collect()` and `GC.GetTotalMemory()` for diagnostics.     │ │
│ │                                                                          │ │
│ │ 5️⃣ Avoid Overusing Finalizers                                          │ │
│ │    └─ Use finalizers only when necessary for unmanaged resources.       │ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                         🧪 📦 SUMMARY CODE BLOCK                         │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ using System;                                                            │ │
│ │                                                                          │ │
│ │ class Resource : IDisposable                                             │ │
│ │ {                                                                        │ │
│ │     public void Dispose()                                                │ │     {                                                                    │ │
│ │         Console.WriteLine("Resource disposed.");                         │ │     }                                                                    │ │
│ │ }                                                                        │ │                                                                          │ │
│ │ using (var resource = new Resource())                                    │ │ {                                                                        │ │
│ │     Console.WriteLine("Using resource.");                                │ │ }                                                                        │ │                                                                          │ │
│ │ // Output:                                                               │ │ // Using resource.                                                       │ │ // Resource disposed.                                                    │ │
└──────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────────────────────────────────────────────────────┐
│                                   🔹 DYNAMIC BINDING                         │
├──────────────────────────────────────────────────────────────────────────────┤
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                             ✅ DEFINITION                                │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ Dynamic Binding allows the resolution of method calls, properties, or    │ │
│ │ operations at runtime instead of compile time.                           │ │
│ │                                                                          │ │
│ │ 🔖 Official Definition (Microsoft):                                     │ │
│ │ "Dynamic binding enables operations to be resolved at runtime, allowing │ │
│ │ for more flexible and dynamic code execution."                          │ │
│ └──────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │ 🎯 WHY WE USE DYNAMIC BINDING - BENEFITS & SCENARIOS                     │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 🔁 1. Interoperability with Dynamic Languages                            │ │
│ │    └─ Enables interaction with COM objects, dynamic libraries, etc.     │ │
│ │                                                                          │ │
│ │ 🧩 2. Simplifies Reflection                                              │ │
│ │    └─ Avoids verbose reflection code for dynamic operations.            │ │
│ │                                                                          │ │
│ │ 🔗 3. Flexible Code Execution                                            │ │
│ │    └─ Allows runtime decisions for method calls or property access.     │ │
│ │                                                                          │ │
│ │ 🛠️ 4. Late Binding                                                       │ │
│ │    └─ Useful when types or methods are not known at compile time.       │ │
│ │                                                                          │ │
│ │ 🔍 5. Dynamic Proxies and Scripting                                      │ │
│ │    └─ Powers frameworks like ASP.NET MVC, dynamic proxies, and scripts. │ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                        ❓ WHAT PROBLEM IT SOLVES                          │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 🚫 1. Avoids Compile-Time Restrictions                                   │ │
│ │    └─ Enables runtime resolution of operations.                         │ │
│ │                                                                          │ │
│ │ 🧩 2. Simplifies Interoperability                                        │ │
│ │    └─ Works seamlessly with dynamic objects like COM or JSON.           │ │
│ │                                                                          │ │
│ │ 🔁 3. Reduces Boilerplate Code                                           │ │
│ │    └─ Avoids repetitive reflection code for dynamic scenarios.          │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                       🔑 ADDITIONAL KEY POINTS                           │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 🔧 1. `dynamic` Keyword                                                  │ │
│ │    └─ Declares variables resolved at runtime.                            │ │
│ │                                                                          │ │
│ │ 🌀 2. RuntimeBinderException                                              │ │
│ │    └─ Thrown when a dynamic operation fails at runtime.                  │ │
│ │                                                                          │ │
│ │ ⚖️ 3. Comparison with `var`                                               │ │
│ │    └─ `var`: Compile-time type inference.                                │ │
│ │    └─ `dynamic`: Runtime type resolution.                                │ │
│ │                                                                          │ │
│ │ 🔗 4. Interoperability with COM and Reflection                           │ │
│ │    └─ Simplifies interaction with COM objects and reflection APIs.       │ │
│ │                                                                          │ │
│ │ 🛠️ 5. Performance Considerations                                         │ │
│ │    └─ Dynamic binding is slower than static binding. Use cautiously.     │ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                     🔍 TYPES OF DYNAMIC BINDING IN C#                    │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 1️⃣ Dynamic Objects                                                     │ │
│ │    └─ Objects declared with the `dynamic` keyword.                      │ │
│ │                                                                          │ │
│ │ 2️⃣ ExpandoObject                                                       │ │
│ │    └─ Runtime extensible objects for dynamic properties.                │ │
│ │                                                                          │ │
│ │ 3️⃣ COM Interoperability                                                │ │
│ │    └─ Simplifies interaction with COM objects.                          │ │
│ │                                                                          │ │
│ │ 4️⃣ Reflection                                                          │ │
│ │    └─ Dynamic invocation of methods or properties.                      │ │
│ │                                                                          │ │
│ │ 5️⃣ Dynamic Proxies                                                     │ │
│ │    └─ Used in frameworks like ASP.NET MVC for dynamic behaviors.        │ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                       🔷 STEPS TO WORK WITH DYNAMIC BINDING              │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 1️⃣ Declare a Dynamic Variable                                          │ │
│ │    └─ `dynamic obj = GetDynamicObject();`                               │ │
│ │                                                                          │ │
│ │ 2️⃣ Access Members Dynamically                                          │ │
│ │    └─ `obj.SomeMethod();` or `obj.SomeProperty = value;`                │ │
│ │                                                                          │ │
│ │ 3️⃣ Use ExpandoObject                                                   │ │
│ │    └─ `dynamic expando = new ExpandoObject();`                          │ │
│ │    └─ `expando.NewProperty = "Value";`                                  │ │
│ │                                                                          │ │
│ │ 4️⃣ Interact with COM Objects                                           │ │
│ │    └─ `dynamic excel = Activator.CreateInstance(Type.GetTypeFromProgID("Excel.Application"));` │ │
│ │                                                                          │ │
│ │ 5️⃣ Handle Runtime Exceptions                                           │ │
│ │    └─ Catch `RuntimeBinderException` for invalid operations.            │ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                         🧪 📦 SUMMARY CODE BLOCK                         │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ using System;                                                            │ │
│ │ using System.Dynamic;                                                    │ │
│ │                                                                          │ │
│ │ dynamic obj = new ExpandoObject();                                       │ │
│ │ obj.Name = "Dynamic Object";                                             │ │
│ │ obj.Print = (Action)(() => Console.WriteLine($"Hello, {obj.Name}!"));    │ │
│ │                                                                          │ │
│ │ obj.Print();                                                             │ │
│ │                                                                          │ │
│ │ // Output:                                                               │ │
│ │ // Hello, Dynamic Object!                                                │ │
└──────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────────────────────────────────────────────────────┐
│                                   🔹 SERIALIZATION                           │
├──────────────────────────────────────────────────────────────────────────────┤
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                             ✅ DEFINITION                                │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ Serialization is the process of converting an object into a format       │ │
│ │ that can be stored or transmitted (e.g., JSON, XML, binary).             │ │
│ │                                                                          │ │
│ │ Deserialization is the reverse process of reconstructing an object       │ │
│ │ from its serialized format.                                              │ │
│ │                                                                          │ │
│ │ 🔖 Official Definition (Microsoft):                                     │ │
│ │ "Serialization is the process of converting an object into a form that  │ │
│ │ can be persisted or transported."                                       │ │
│ └──────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │ 🎯 WHY WE USE SERIALIZATION - BENEFITS & SCENARIOS                       │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 🔁 1. Data Persistence                                                   │ │
│ │    └─ Save objects to files or databases for later use.                 │ │
│ │                                                                          │ │
│ │ 🧩 2. Data Transmission                                                  │ │
│ │    └─ Send objects over networks (e.g., APIs, sockets).                 │ │
│ │                                                                          │ │
│ │ 🔗 3. Interoperability                                                   │ │
│ │    └─ Exchange data between systems using standard formats like JSON.   │ │
│ │                                                                          │ │
│ │ 🛠️ 4. Caching                                                            │ │
│ │    └─ Serialize objects for quick retrieval from memory or disk.        │ │
│ │                                                                          │ │
│ │ 🔍 5. Logging and Debugging                                              │ │
│ │    └─ Serialize objects for detailed logs or debugging snapshots.       │ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                        ❓ WHAT PROBLEM IT SOLVES                          │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 🚫 1. Avoids Manual Data Conversion                                      │ │
│ │    └─ Automates object-to-format conversion.                            │ │
│ │                                                                          │ │
│ │ 🧩 2. Enables Cross-Platform Communication                               │ │
│ │    └─ Standard formats like JSON/XML ensure compatibility.              │ │
│ │                                                                          │ │
│ │ 🔁 3. Simplifies Data Storage and Retrieval                              │ │
│ │    └─ Easily save and load objects without manual parsing.              │ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                       🔑 ADDITIONAL KEY POINTS                           │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 🔧 1. Attributes for Serialization                                       │ │
│ │    └─ Use `[Serializable]` for binary serialization.                    │ │
│ │    └─ Use `[DataContract]` and `[DataMember]` for custom serialization. │ │
│ │                                                                          │ │
│ │ 🌀 2. JSON and XML Serialization                                         │ │
│ │    └─ Use `System.Text.Json` or `System.Xml.Serialization`.             │ │
│ │                                                                          │ │
│ │ ⚖️ 3. Binary Serialization                                               │ │
│ │    └─ Efficient but not human-readable.                                 │ │
│ │                                                                          │ │
│ │ 🔗 4. Versioning                                                         │ │
│ │    └─ Handle schema changes with optional fields or defaults.           │ │
│ │                                                                          │ │
│ │ 🛠️ 5. Security Considerations                                            │ │
│ │    └─ Avoid deserializing untrusted data to prevent attacks.            │ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                     🔍 TYPES OF SERIALIZATION IN C#                      │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 1️⃣ Binary Serialization                                                │ │
│ │    └─ Converts objects to binary format.                                │ │
│ │                                                                          │ │
│ │ 2️⃣ JSON Serialization                                                  │ │
│ │    └─ Converts objects to JSON format using `System.Text.Json`.         │ │
│ │                                                                          │ │
│ │ 3️⃣ XML Serialization                                                   │ │
│ │    └─ Converts objects to XML format using `System.Xml.Serialization`.  │ │
│ │                                                                          │ │
│ │ 4️⃣ Custom Serialization                                                │ │
│ │    └─ Implement `ISerializable` for custom logic.                       │ │
│ │                                                                          │ │
│ │ 5️⃣ Data Contract Serialization                                         │ │
│ │    └─ Use `[DataContract]` for fine-grained control.                    │ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                       🔷 STEPS TO WORK WITH SERIALIZATION                │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 1️⃣ Mark Class as Serializable                                          │ │
│ │    └─ `[Serializable]` or `[DataContract]`.                             │ │
│ │                                                                          │ │
│ │ 2️⃣ Serialize Object to Format                                          │ │
│ │    └─ Use `JsonSerializer.Serialize(obj)` for JSON.                     │ │
│ │                                                                          │ │
│ │ 3️⃣ Save Serialized Data                                                │ │
│ │    └─ Write serialized data to file, database, or network.              │ │
│ │                                                                          │ │
│ │ 4️⃣ Deserialize to Object                                               │ │
│ │    └─ Use `JsonSerializer.Deserialize<T>(data)` for JSON.               │ │
│ │                                                                          │ │
│ │ 5️⃣ Handle Serialization Exceptions                                     │ │
│ │    └─ Catch `SerializationException` for error handling.                │ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                         🧪 📦 SUMMARY CODE BLOCK                         │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ using System;                                                            │ │
│ │ using System.Text.Json;                                                  │ │
│ │                                                                          │ │
│ │ [Serializable]                                                           │ │
│ │ public class Person                                                      │ │
│ │ {                                                                        │ │
│ │     public string Name { get; set; }                                     │ │
│ │     public int Age { get; set; }                                         │ │
│ │ }                                                                        │ │
│ │                                                                          │ │
│ │ Person person = new Person { Name = "John", Age = 30 };                  │ │
│ │ string json = JsonSerializer.Serialize(person);                          │ │
│ │ Console.WriteLine(json);                                                 │ │
│ │                                                                          │ │
│ │ Person deserialized = JsonSerializer.Deserialize<Person>(json);          │ │
│ │ Console.WriteLine($"{deserialized.Name}, {deserialized.Age}");           │ │
│ │                                                                          │ │
│ │ // Output:                                                               │ │
│ │ // {"Name":"John","Age":30}                                              │ │
│ │ // John, 30                                                              │ │
└──────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────────────────────────────────────────────────────┐
│                             🔹 APPLICATION DOMAINS                          │
├──────────────────────────────────────────────────────────────────────────────┤
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                             ✅ DEFINITION                                │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ Application Domains (AppDomains) provide isolation between applications │ │
│ │ running in the same process. They allow loading and unloading of code    │ │
│ │ dynamically without affecting other domains.                             │ │
│ │                                                                          │ │
│ │ 🔖 Official Definition (Microsoft):                                     │ │
│ │ "An application domain is a mechanism used within the .NET Framework to │ │
│ │ isolate executed software applications from one another."               │ │
│ └──────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │ 🎯 WHY WE USE APPLICATION DOMAINS - BENEFITS & SCENARIOS                 │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 🔁 1. Isolation                                                          │ │
│ │    └─ Prevents one application from crashing others in the same process.│ │
│ │                                                                          │ │
│ │ 🧩 2. Dynamic Code Loading                                               │ │
│ │    └─ Load and unload assemblies dynamically at runtime.                │ │
│ │                                                                          │ │
│ │ 🔗 3. Security                                                           │ │
│ │    └─ Enforces security boundaries between applications.                │ │
│ │                                                                          │ │
│ │ 🛠️ 4. Resource Management                                                │ │
│ │    └─ Unload unused AppDomains to free resources.                       │ │
│ │                                                                          │ │
│ │ 🔍 5. Testing and Debugging                                              │ │
│ │    └─ Run tests in isolated domains to avoid side effects.              │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                        ❓ WHAT PROBLEM IT SOLVES                          │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 🚫 1. Prevents Process Crashes                                           │ │
│ │    └─ Isolates faults to specific AppDomains.                           │ │
│ │                                                                          │ │
│ │ 🧩 2. Enables Dynamic Assembly Loading                                   │ │
│ │    └─ Load plugins or modules without restarting the application.       │ │
│ │                                                                          │ │
│ │ 🔁 3. Simplifies Resource Cleanup                                        │ │
│ │    └─ Unload AppDomains to release memory and resources.                │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                       🔑 ADDITIONAL KEY POINTS                           │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 🔧 1. AppDomain Class                                                    │ │
│ │    └─ Use `System.AppDomain` to create and manage domains.              │ │
│ │                                                                          │ │
│ │ 🌀 2. Cross-Domain Communication                                         │ │
│ │    └─ Use `MarshalByRefObject` for objects shared between domains.      │ │
│ │                                                                          │ │
│ │ ⚖️ 3. Comparison with Processes                                          │ │
│ │    └─ AppDomains are lighter than processes but share the same memory.  │ │
│ │                                                                          │ │
│ │ 🔗 4. Security Considerations                                            │ │
│ │    └─ AppDomains enforce code access security policies.                 │ │
│ │                                                                          │ │
│ │ 🛠️ 5. Deprecation in .NET Core                                           │ │
│ │    └─ AppDomains are not supported in .NET Core; use `AssemblyLoadContext`. │ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                     🔍 TYPES OF APPLICATION DOMAINS IN C#                │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 1️⃣ Default AppDomain                                                   │ │
│ │    └─ Automatically created when the application starts.                │ │
│ │                                                                          │ │
│ │ 2️⃣ Custom AppDomain                                                    │ │
│ │    └─ Created programmatically using `AppDomain.CreateDomain()`.        │ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                       🔷 STEPS TO WORK WITH APPLICATION DOMAINS          │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 1️⃣ Create a New AppDomain                                              │ │
│ │    └─ `AppDomain newDomain = AppDomain.CreateDomain("NewDomain");`      │ │
│ │                                                                          │ │
│ │ 2️⃣ Load an Assembly into AppDomain                                     │ │
│ │    └─ `newDomain.Load("MyAssembly");`                                   │ │
│ │                                                                          │ │
│ │ 3️⃣ Execute Code in AppDomain                                           │ │
│ │    └─ Use `newDomain.DoCallBack()` to execute code.                     │ │
│ │                                                                          │ │
│ │ 4️⃣ Unload AppDomain                                                    │ │
│ │    └─ `AppDomain.Unload(newDomain);`                                    │ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                         🧪 📦 SUMMARY CODE BLOCK                         │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ using System;                                                            │ │
│ │                                                                          │ │
│ │ AppDomain newDomain = AppDomain.CreateDomain("NewDomain");               │ │
│ │ newDomain.DoCallBack(() => Console.WriteLine("Hello from NewDomain!"));  │ │
│ │ AppDomain.Unload(newDomain);                                             │ │
│ │                                                                          │ │
│ │ // Output:                                                               │ │
│ │ // Hello from NewDomain!                                                 │ │
└──────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────────────────────────────────────────────────────┐
│                                   🔹 LAMBDA                                  │
├──────────────────────────────────────────────────────────────────────────────┤
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                             ✅ DEFINITION                                │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ A Lambda Expression is a concise way to represent an anonymous function │ │
│ │ using the `=>` syntax.                                                   │ │
│ │                                                                          │ │
│ │ 🔖 Official Definition (Microsoft):                                     │ │
│ │ "A lambda expression is a short block of code which takes parameters    │ │
│ │ and returns a value."                                                   │ │
│ └──────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │ 🎯 WHY WE USE LAMBDA - BENEFITS & SCENARIOS                              │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 🔁 1. Concise Syntax                                                     │ │
│ │    └─ Reduces boilerplate code for small functions.                     │ │
│ │                                                                          │ │
│ │ 🧩 2. Functional Programming                                             │ │
│ │    └─ Enables higher-order functions and immutability.                  │ │
│ │                                                                          │ │
│ │ 🔗 3. LINQ and Collections                                               │ │
│ │    └─ Widely used in LINQ queries and collection operations.            │ │
│ │                                                                          │ │
│ │ 🛠️ 4. Event Handling                                                     │ │
│ │    └─ Simplifies event subscription with inline logic.                  │ │
│ │                                                                          │ │
│ │ 🔍 5. Readability                                                        │ │
│ │    └─ Improves code readability for simple operations.                  │ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                        ❓ WHAT PROBLEM IT SOLVES                          │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 🚫 1. Avoids Verbose Anonymous Methods                                   │ │
│ │    └─ Replaces `delegate` keyword with concise syntax.                  │ │
│ │                                                                          │ │
│ │ 🧩 2. Simplifies Inline Logic                                            │ │
│ │    └─ Reduces the need for separate method declarations.                │ │
│ │                                                                          │ │
│ │ 🔁 3. Enhances Functional Programming                                    │ │
│ │    └─ Enables declarative and functional coding styles.                 │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                       🔑 ADDITIONAL KEY POINTS                           │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 🔧 1. Syntax                                                             │ │
│ │    └─ `(parameters) => expression` or `{ statements }`.                 │ │
│ │                                                                          │ │
│ │ 🌀 2. Capturing Variables                                                │ │
│ │    └─ Lambdas can capture variables from their enclosing scope.         │ │
│ │                                                                          │ │
│ │ ⚖️ 3. Comparison with Delegates                                          │ │
│ │    └─ Lambdas are syntactic sugar over delegates.                       │ │
│ │                                                                          │ │
│ │ 🔗 4. LINQ Integration                                                   │ │
│ │    └─ Core to LINQ queries for filtering, mapping, and aggregation.     │ │
│ │                                                                          │ │
│ │ 🛠️ 5. Expression Trees                                                   │ │
│ │    └─ Lambdas can be compiled into expression trees for dynamic queries.│ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                     🔍 TYPES OF LAMBDA IN C#                             │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 1️⃣ Single-Line Lambda                                                  │ │
│ │    └─ `(x) => x * x`.                                                   │ │
│ │                                                                          │ │
│ │ 2️⃣ Multi-Line Lambda                                                   │ │
│ │    └─ `(x) => { return x * x; }`.                                       │ │
│ │                                                                          │ │
│ │ 3️⃣ Parameterless Lambda                                                │ │
│ │    └─ `() => Console.WriteLine("Hello!");`.                             │ │
│ │                                                                          │ │
│ │ 4️⃣ Lambda with Multiple Parameters                                     │ │
│ │    └─ `(x, y) => x + y`.                                                │ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                       🔷 STEPS TO WORK WITH LAMBDA                       │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 1️⃣ Define a Lambda Expression                                          │ │
│ │    └─ `Func<int, int> square = x => x * x;`.                            │ │
│ │                                                                          │ │
│ │ 2️⃣ Use Lambda in LINQ                                                  │ │
│ │    └─ `var evens = numbers.Where(x => x % 2 == 0);`.                    │ │
│ │                                                                          │ │
│ │ 3️⃣ Pass Lambda to a Method                                             │ │
│ │    └─ `Execute(x => x * x);`.                                           │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                         🧪 📦 SUMMARY CODE BLOCK                         │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ using System;                                                            │ │
│ │ using System.Linq;                                                       │ │
│ │                                                                          │ │
│ │ int[] numbers = { 1, 2, 3, 4, 5 };                                       │ │
│ │ var squares = numbers.Select(x => x * x);                                │ │
│ │ foreach (var square in squares)                                          │ │
│ │ {                                                                        │ │
│ │     Console.WriteLine(square);                                           │ │
│ │ }                                                                        │ │
│ │                                                                          │ │
│ │ // Output:                                                               │ │
│ │ // 1                                                                     │ │
│ │ // 4                                                                     │ │
│ │ // 9                                                                     │ │
│ │ // 16                                                                    │ │
│ │ // 25                                                                    │ │
└──────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────────────────────────────────────────────────────┐
│                                   🔹 THREADING                               │
├──────────────────────────────────────────────────────────────────────────────┤
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                             ✅ DEFINITION                                │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ Threading allows multiple threads to run concurrently within a process. │ │
│ │ Threads share the same memory space but execute independently.          │ │
│ │                                                                          │ │
│ │ 🔖 Official Definition (Microsoft):                                     │ │
│ │ "Threading enables parallel execution of code by dividing a program     │ │
│ │ into multiple threads."                                                 │ │
│ └──────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │ 🎯 WHY WE USE THREADING - BENEFITS & SCENARIOS                           │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 🔁 1. Parallelism                                                        │ │
│ │    └─ Perform multiple tasks simultaneously to improve performance.     │ │
│ │                                                                          │ │
│ │ 🧩 2. Responsiveness                                                     │ │
│ │    └─ Keep UI responsive by running tasks in the background.            │ │
│ │                                                                          │ │
│ │ 🔗 3. Resource Utilization                                               │ │
│ │    └─ Utilize multi-core processors effectively.                        │ │
│ │                                                                          │ │
│ │ 🛠️ 4. Background Processing                                              │ │
│ │    └─ Run long-running tasks without blocking the main thread.          │ │
│ │                                                                          │ │
│ │ 🔍 5. Scalability                                                        │ │
│ │    └─ Handle multiple client requests in server applications.           │ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                        ❓ WHAT PROBLEM IT SOLVES                          │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 🚫 1. Avoids Blocking                                                    │ │
│ │    └─ Prevents the main thread from being blocked by long tasks.         │ │
│ │                                                                          │ │
│ │ 🧩 2. Enables Concurrency                                                │ │
│ │    └─ Allows multiple tasks to run concurrently.                        │ │
│ │                                                                          │ │
│ │ 🔁 3. Improves Performance                                               │ │
│ │    └─ Reduces idle time by utilizing CPU cores efficiently.             │ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                       🔑 ADDITIONAL KEY POINTS                           │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 🔧 1. Thread Class                                                       │ │
│ │    └─ Use `System.Threading.Thread` to create and manage threads.       │ │
│ │                                                                          │ │
│ │ 🌀 2. Thread Safety                                                      │ │
│ │    └─ Use locks or synchronization primitives to avoid race conditions. │ │
│ │                                                                          │ │
│ │ ⚖️ 3. Thread Pool                                                        │ │
│ │    └─ Use `ThreadPool` for efficient thread management.                 │ │
│ │                                                                          │ │
│ │ 🔗 4. Background vs Foreground Threads                                   │ │
│ │    └─ Background threads terminate when the main thread exits.          │ │
│ │                                                                          │ │
│ │ 🛠️ 5. Task Parallel Library (TPL)                                        │ │
│ │    └─ Use `Task` for higher-level threading abstractions.               │ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                     🔍 TYPES OF THREADING IN C#                          │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 1️⃣ Manual Threading                                                    │ │
│ │    └─ Create threads using `Thread` class.                              │ │
│ │                                                                          │ │
│ │ 2️⃣ Thread Pool                                                         │ │
│ │    └─ Use `ThreadPool` for managing a pool of worker threads.           │ │
│ │                                                                          │ │
│ │ 3️⃣ Task Parallel Library (TPL)                                         │ │
│ │    └─ Use `Task` and `Parallel` for simplified threading.               │ │
│ │                                                                          │ │
│ │ 4️⃣ Asynchronous Programming                                            │ │
│ │    └─ Use `async` and `await` for non-blocking operations.              │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                       🔷 STEPS TO WORK WITH THREADING                    │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 1️⃣ Create a Thread                                                     │ │
│ │    └─ `Thread thread = new Thread(SomeMethod);`.                        │ │
│ │                                                                          │ │
│ │ 2️⃣ Start the Thread                                                    │ │
│ │    └─ `thread.Start();`.                                                │ │
│ │                                                                          │ │
│ │ 3️⃣ Synchronize Threads                                                │ │
│ │    └─ Use `lock` or `Monitor` for thread safety.                        │ │
│ │                                                                          │ │
│ │ 4️⃣ Use Thread Pool                                                    │ │
│ │    └─ `ThreadPool.QueueUserWorkItem(SomeMethod);`.                      │ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                         🧪 📦 SUMMARY CODE BLOCK                         │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ using System;                                                            │ │
│ │ using System.Threading;                                                  │ │
│ │                                                                          │ │
│ │ void PrintNumbers()                                                      │ │
│ │ {                                                                        │ │
│ │     for (int i = 1; i <= 5; i++)                                         │ │
│ │     {                                                                    │ │
│ │         Console.WriteLine(i);                                            │ │
│ │         Thread.Sleep(500);                                               │ │
│ │     }                                                                    │ │
│ │ }                                                                        │ │
│ │                                                                          │ │
│ │ Thread thread = new Thread(PrintNumbers);                                │ │
│ │ thread.Start();                                                          │ │
│ │                                                                          │ │
│ │ // Output:                                                               │ │
│ │ // 1                                                                     │ │
│ │ // 2                                                                     │ │
│ │ // 3                                                                     │ │
│ │ // 4                                                                     │ │
│ │ // 5                                                                     │ │
└──────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────────────────────────────────────────────────────┐
│                     🔹 ASYNCHRONOUS PROGRAMMING                             │
├──────────────────────────────────────────────────────────────────────────────┤
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                             ✅ DEFINITION                                │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ Asynchronous Programming allows non-blocking execution of tasks,         │ │
│ │ enabling efficient use of resources and responsive applications.         │ │
│ │                                                                          │ │
│ │ 🔖 Official Definition (Microsoft):                                     │ │
│ │ "Asynchronous programming is a means of writing non-blocking code that  │ │
│ │ allows tasks to run concurrently."                                      │ │
│ └──────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │ 🎯 WHY WE USE ASYNCHRONOUS PROGRAMMING - BENEFITS & SCENARIOS            │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 🔁 1. Non-Blocking Operations                                            │ │
│ │    └─ Prevents UI freezing in desktop or mobile applications.           │ │
│ │                                                                          │ │
│ │ 🧩 2. Scalability                                                        │ │
│ │    └─ Handles multiple requests efficiently in web servers.             │ │
│ │                                                                          │ │
│ │ 🔗 3. Resource Optimization                                              │ │
│ │    └─ Frees up threads while waiting for I/O operations.                │ │
│ │                                                                          │ │
│ │ 🛠️ 4. Improved User Experience                                           │ │
│ │    └─ Keeps applications responsive during long-running tasks.          │ │
│ │                                                                          │ │
│ │ 🔍 5. Parallelism                                                        │ │
│ │    └─ Enables concurrent execution of independent tasks.                │ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                        ❓ WHAT PROBLEM IT SOLVES                          │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 🚫 1. Avoids Blocking                                                    │ │
│ │    └─ Prevents the main thread from being blocked by long tasks.         │ │
│ │                                                                          │ │
│ │ 🧩 2. Enables Concurrency                                                │ │
│ │    └─ Allows multiple tasks to run concurrently.                        │ │
│ │                                                                          │ │
│ │ 🔁 3. Improves Performance                                               │ │
│ │    └─ Reduces idle time by utilizing CPU cores efficiently.             │ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                       🔑 ADDITIONAL KEY POINTS                           │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 🔧 1. `async` and `await` Keywords                                       │ │
│ │    └─ Simplify asynchronous programming in C#.                          │ │
│ │                                                                          │ │
│ │ 🌀 2. Task-Based Asynchronous Pattern (TAP)                              │ │
│ │    └─ Use `Task` and `Task<T>` for async operations.                    │ │
│ │                                                                          │ │
│ │ ⚖️ 3. Comparison with Threads                                            │ │
│ │    └─ Asynchronous programming is higher-level and more efficient.      │ │
│ │                                                                          │ │
│ │ 🔗 4. I/O-Bound vs CPU-Bound Tasks                                       │ │
│ │    └─ Use async for I/O-bound tasks and threads for CPU-bound tasks.    │ │
│ │                                                                          │ │
│ │ 🛠️ 5. Exception Handling                                                 │ │
│ │    └─ Use `try-catch` blocks with `await` for error handling.           │ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                     🔍 TYPES OF ASYNCHRONOUS PROGRAMMING IN C#           │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 1️⃣ Async/Await                                                         │ │
│ │    └─ Simplifies asynchronous code with `async` and `await`.            │ │
│ │                                                                          │ │
│ │ 2️⃣ Task-Based Asynchronous Pattern (TAP)                               │ │
│ │    └─ Uses `Task` and `Task<T>` for async operations.                   │ │
│ │                                                                          │ │
│ │ 3️⃣ Event-Based Asynchronous Pattern (EAP)                              │ │
│ │    └─ Uses events for async operations (legacy pattern).                │ │
│ │                                                                          │ │
│ │ 4️⃣ Asynchronous Programming Model (APM)                                │ │
│ │    └─ Uses `Begin` and `End` methods for async operations (legacy).     │ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                       🔷 STEPS TO WORK WITH ASYNCHRONOUS PROGRAMMING     │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ 1️⃣ Define an Async Method                                              │ │
│ │    └─ `async Task SomeMethodAsync() { await Task.Delay(1000); }`.       │ │
│ │                                                                          │ │
│ │ 2️⃣ Call Async Method                                                   │ │
│ │    └─ `await SomeMethodAsync();`.                                       │ │
│ │                                                                          │ │
│ │ 3️⃣ Handle Exceptions                                                   │ │
│ │    └─ Use `try-catch` blocks around `await` calls.                      │ │
└──────────────────────────────────────────────────────────────────────────────┘ │
│                                                                              │
│ ┌──────────────────────────────────────────────────────────────────────────┐ │
│ │                         🧪 📦 SUMMARY CODE BLOCK                         │ │
│ ├──────────────────────────────────────────────────────────────────────────┤ │
│ │ using System;                                                            │ │
│ │ using System.Threading.Tasks;                                            │ │
│ │                                                                          │ │
│ │ async Task PrintNumbersAsync()                                           │ │
│ │ {                                                                        │ │
│ │     for (int i = 1; i <= 5; i++)                                         │ │
│ │     {                                                                    │ │
│ │         Console.WriteLine(i);                                            │ │
│ │         await Task.Delay(500);                                           │ │
│ │     }                                                                    │ │
│ │ }                                                                        │ │
│ │                                                                          │ │
│ │ await PrintNumbersAsync();                                               │ │
│ │                                                                          │ │
│ │ // Output:                                                               │ │
│ │ // 1                                                                     │ │
│ │ // 2                                                                     │ │
│ │ // 3                                                                     │ │
│ │ // 4                                                                     │ │
│ │ // 5                                                                     │ │
└──────────────────────────────────────────────────────────────────────────────┘

