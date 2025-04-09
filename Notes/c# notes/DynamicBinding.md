# 🔹 DYNAMIC BINDING

## ✅ DEFINITION
Dynamic Binding allows the resolution of method calls, properties, or operations at runtime instead of compile time.

**🔖 Official Definition (Microsoft):**  
"Dynamic binding enables operations to be resolved at runtime, allowing for more flexible and dynamic code execution."

---

## 🎯 WHY WE USE DYNAMIC BINDING - BENEFITS & SCENARIOS
- 🔁 **Interoperability with Dynamic Languages**  
  - Enables interaction with COM objects, dynamic libraries, etc.  
- 🧩 **Simplifies Reflection**  
  - Avoids verbose reflection code for dynamic operations.  
- 🔗 **Flexible Code Execution**  
  - Allows runtime decisions for method calls or property access.  
- 🛠️ **Late Binding**  
  - Useful when types or methods are not known at compile time.  
- 🔍 **Dynamic Proxies and Scripting**  
  - Powers frameworks like ASP.NET MVC, dynamic proxies, and scripts.

---

## ❓ WHAT PROBLEM IT SOLVES
- 🚫 **Avoids Compile-Time Restrictions**  
  - Enables runtime resolution of operations.  
- 🧩 **Simplifies Interoperability**  
  - Works seamlessly with dynamic objects like COM or JSON.  
- 🔁 **Reduces Boilerplate Code**  
  - Avoids repetitive reflection code for dynamic scenarios.

---

## 🔑 ADDITIONAL KEY POINTS
- 🔧 **`dynamic` Keyword**  
  - Declares variables resolved at runtime.  
- 🌀 **RuntimeBinderException**  
  - Thrown when a dynamic operation fails at runtime.  
- ⚖️ **Comparison with `var`**  
  - `var`: Compile-time type inference.  
  - `dynamic`: Runtime type resolution.  
- 🔗 **Interoperability with COM and Reflection**  
  - Simplifies interaction with COM objects and reflection APIs.  
- 🛠️ **Performance Considerations**  
  - Dynamic binding is slower than static binding. Use cautiously.

---

## 🔍 TYPES OF DYNAMIC BINDING IN C#
1️⃣ **Dynamic Objects**  
   - Objects declared with the `dynamic` keyword.  
2️⃣ **ExpandoObject**  
   - Runtime extensible objects for dynamic properties.  
3️⃣ **COM Interoperability**  
   - Simplifies interaction with COM objects.  
4️⃣ **Reflection**  
   - Dynamic invocation of methods or properties.  
5️⃣ **Dynamic Proxies**  
   - Used in frameworks like ASP.NET MVC for dynamic behaviors.

---

## 🔷 STEPS TO WORK WITH DYNAMIC BINDING
1️⃣ **Declare a Dynamic Variable**  
   - `dynamic obj = GetDynamicObject();`  
2️⃣ **Access Members Dynamically**  
   - `obj.SomeMethod();` or `obj.SomeProperty = value;`  
3️⃣ **Use ExpandoObject**  
   - `dynamic expando = new ExpandoObject();`  
   - `expando.NewProperty = "Value";`  
4️⃣ **Interact with COM Objects**  
   - `dynamic excel = Activator.CreateInstance(Type.GetTypeFromProgID("Excel.Application"));`  
5️⃣ **Handle Runtime Exceptions**  
   - Catch `RuntimeBinderException` for invalid operations.

---

## 🧪 📦 SUMMARY CODE BLOCK
```csharp
using System;
using System.Dynamic;

dynamic obj = new ExpandoObject();
obj.Name = "Dynamic Object";
obj.Print = (Action)(() => Console.WriteLine($"Hello, {obj.Name}!"));

obj.Print();

// Output:
// Hello, Dynamic Object!
```
