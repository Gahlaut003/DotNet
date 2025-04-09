# 🔹 SERIALIZATION

## ✅ DEFINITION
Serialization is the process of converting an object into a format that can be stored or transmitted (e.g., JSON, XML, binary).  
Deserialization is the reverse process of reconstructing an object from its serialized format.

**🔖 Official Definition (Microsoft):**  
"Serialization is the process of converting an object into a form that can be persisted or transported."

---

## 🎯 WHY WE USE SERIALIZATION - BENEFITS & SCENARIOS
- 🔁 **Data Persistence**  
  - Save objects to files or databases for later use.  
- 🧩 **Data Transmission**  
  - Send objects over networks (e.g., APIs, sockets).  
- 🔗 **Interoperability**  
  - Exchange data between systems using standard formats like JSON.  
- 🛠️ **Caching**  
  - Serialize objects for quick retrieval from memory or disk.  
- 🔍 **Logging and Debugging**  
  - Serialize objects for detailed logs or debugging snapshots.

---

## ❓ WHAT PROBLEM IT SOLVES
- 🚫 **Avoids Manual Data Conversion**  
  - Automates object-to-format conversion.  
- 🧩 **Enables Cross-Platform Communication**  
  - Standard formats like JSON/XML ensure compatibility.  
- 🔁 **Simplifies Data Storage and Retrieval**  
  - Easily save and load objects without manual parsing.

---

## 🔑 ADDITIONAL KEY POINTS
- 🔧 **Attributes for Serialization**  
  - Use `[Serializable]` for binary serialization.  
  - Use `[DataContract]` and `[DataMember]` for custom serialization.  
- 🌀 **JSON and XML Serialization**  
  - Use `System.Text.Json` or `System.Xml.Serialization`.  
- ⚖️ **Binary Serialization**  
  - Efficient but not human-readable.  
- 🔗 **Versioning**  
  - Handle schema changes with optional fields or defaults.  
- 🛠️ **Security Considerations**  
  - Avoid deserializing untrusted data to prevent attacks.

---

## 🔍 TYPES OF SERIALIZATION IN C#
1️⃣ **Binary Serialization**  
   - Converts objects to binary format.  
2️⃣ **JSON Serialization**  
   - Converts objects to JSON format using `System.Text.Json`.  
3️⃣ **XML Serialization**  
   - Converts objects to XML format using `System.Xml.Serialization`.  
4️⃣ **Custom Serialization**  
   - Implement `ISerializable` for custom logic.  
5️⃣ **Data Contract Serialization**  
   - Use `[DataContract]` for fine-grained control.

---

## 🧪 📦 SUMMARY CODE BLOCK
```csharp
using System;
using System.Text.Json;

[Serializable]
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

Person person = new Person { Name = "John", Age = 30 };
string json = JsonSerializer.Serialize(person);
Console.WriteLine(json);

Person deserialized = JsonSerializer.Deserialize<Person>(json);
Console.WriteLine($"{deserialized.Name}, {deserialized.Age}");

// Output:
// {"Name":"John","Age":30}
// John, 30
```

---

# 🔹 APPLICATION DOMAINS

## ✅ DEFINITION
Application Domains (AppDomains) provide isolation between applications running in the same process. They allow loading and unloading of code dynamically without affecting other domains.

**🔖 Official Definition (Microsoft):**  
"An application domain is a mechanism used within the .NET Framework to isolate executed software applications from one another."

---

## 🎯 WHY WE USE APPLICATION DOMAINS - BENEFITS & SCENARIOS
- 🔁 **Isolation**  
  - Prevents one application from crashing others in the same process.  
- 🧩 **Dynamic Code Loading**  
  - Load and unload assemblies dynamically at runtime.  
- 🔗 **Security**  
  - Enforces security boundaries between applications.  
- 🛠️ **Resource Management**  
  - Unload unused AppDomains to free resources.  
- 🔍 **Testing and Debugging**  
  - Run tests in isolated domains to avoid side effects.

---

## 🔷 STEPS TO WORK WITH APPLICATION DOMAINS
1️⃣ **Create a New AppDomain**  
   - `AppDomain newDomain = AppDomain.CreateDomain("NewDomain");`  
2️⃣ **Load an Assembly into AppDomain**  
   - `newDomain.Load("MyAssembly");`  
3️⃣ **Execute Code in AppDomain**  
   - Use `newDomain.DoCallBack()` to execute code.  
4️⃣ **Unload AppDomain**  
   - `AppDomain.Unload(newDomain);`

---

## 🧪 📦 SUMMARY CODE BLOCK
```csharp
using System;

AppDomain newDomain = AppDomain.CreateDomain("NewDomain");
newDomain.DoCallBack(() => Console.WriteLine("Hello from NewDomain!"));
AppDomain.Unload(newDomain);

// Output:
// Hello from NewDomain!
```

---

# 🔹 LAMBDA

## ✅ DEFINITION
A Lambda Expression is a concise way to represent an anonymous function using the `=>` syntax.

**🔖 Official Definition (Microsoft):**  
"A lambda expression is a short block of code which takes parameters and returns a value."

---

## 🎯 WHY WE USE LAMBDA - BENEFITS & SCENARIOS
- 🔁 **Concise Syntax**  
  - Reduces boilerplate code for small functions.  
- 🧩 **Functional Programming**  
  - Enables higher-order functions and immutability.  
- 🔗 **LINQ and Collections**  
  - Widely used in LINQ queries and collection operations.  
- 🛠️ **Event Handling**  
  - Simplifies event subscription with inline logic.  
- 🔍 **Readability**  
  - Improves code readability for simple operations.

---

## 🔷 STEPS TO WORK WITH LAMBDA
1️⃣ **Define a Lambda Expression**  
   - `Func<int, int> square = x => x * x;`.  
2️⃣ **Use Lambda in LINQ**  
   - `var evens = numbers.Where(x => x % 2 == 0);`.  
3️⃣ **Pass Lambda to a Method**  
   - `Execute(x => x * x);`.

---

## 🧪 📦 SUMMARY CODE BLOCK
```csharp
using System;
using System.Linq;

int[] numbers = { 1, 2, 3, 4, 5 };
var squares = numbers.Select(x => x * x);
foreach (var square in squares)
{
    Console.WriteLine(square);
}

// Output:
// 1
// 4
// 9
// 16
// 25
```

---

# 🔹 THREADING

## ✅ DEFINITION
Threading allows multiple threads to run concurrently within a process. Threads share the same memory space but execute independently.

**🔖 Official Definition (Microsoft):**  
"Threading enables parallel execution of code by dividing a program into multiple threads."

---

## 🎯 WHY WE USE THREADING - BENEFITS & SCENARIOS
- 🔁 **Parallelism**  
  - Perform multiple tasks simultaneously to improve performance.  
- 🧩 **Responsiveness**  
  - Keep UI responsive by running tasks in the background.  
- 🔗 **Resource Utilization**  
  - Utilize multi-core processors effectively.  
- 🛠️ **Background Processing**  
  - Run long-running tasks without blocking the main thread.  
- 🔍 **Scalability**  
  - Handle multiple client requests in server applications.

---

## 🔷 STEPS TO WORK WITH THREADING
1️⃣ **Create a Thread**  
   - `Thread thread = new Thread(SomeMethod);`.  
2️⃣ **Start the Thread**  
   - `thread.Start();`.  
3️⃣ **Synchronize Threads**  
   - Use `lock` or `Monitor` for thread safety.  
4️⃣ **Use Thread Pool**  
   - `ThreadPool.QueueUserWorkItem(SomeMethod);`.

---

## 🧪 📦 SUMMARY CODE BLOCK
```csharp
using System;
using System.Threading;

void PrintNumbers()
{
    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine(i);
        Thread.Sleep(500);
    }
}

Thread thread = new Thread(PrintNumbers);
thread.Start();

// Output:
// 1
// 2
// 3
// 4
// 5
```

---

# 🔹 ASYNCHRONOUS PROGRAMMING

## ✅ DEFINITION
Asynchronous Programming allows non-blocking execution of tasks, enabling efficient use of resources and responsive applications.

**🔖 Official Definition (Microsoft):**  
"Asynchronous programming is a means of writing non-blocking code that allows tasks to run concurrently."

---

## 🎯 WHY WE USE ASYNCHRONOUS PROGRAMMING - BENEFITS & SCENARIOS
- 🔁 **Non-Blocking Operations**  
  - Prevents UI freezing in desktop or mobile applications.  
- 🧩 **Scalability**  
  - Handles multiple requests efficiently in web servers.  
- 🔗 **Resource Optimization**  
  - Frees up threads while waiting for I/O operations.  
- 🛠️ **Improved User Experience**  
  - Keeps applications responsive during long-running tasks.  
- 🔍 **Parallelism**  
  - Enables concurrent execution of independent tasks.

---

## 🔷 STEPS TO WORK WITH ASYNCHRONOUS PROGRAMMING
1️⃣ **Define an Async Method**  
   - `async Task SomeMethodAsync() { await Task.Delay(1000); }`.  
2️⃣ **Call Async Method**  
   - `await SomeMethodAsync();`.  
3️⃣ **Handle Exceptions**  
   - Use `try-catch` blocks around `await` calls.

---

## 🧪 📦 SUMMARY CODE BLOCK
```csharp
using System;
using System.Threading.Tasks;

async Task PrintNumbersAsync()
{
    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine(i);
        await Task.Delay(500);
    }
}

await PrintNumbersAsync();

// Output:
// 1
// 2
// 3
// 4
// 5
```
