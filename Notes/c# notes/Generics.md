# 🔹 GENERICS

## ✅ DEFINITION
Generics allow you to define type-safe data structures and methods without committing to a specific data type.

**🔖 Official Definition (Microsoft):**  
"Generics allow you to define a class, method, delegate, or interface with a placeholder for the type of its data."

---

## 🎯 WHY WE USE GENERICS - BENEFITS & SCENARIOS
- 🔁 **Type Safety**  
  - Prevents runtime type errors by enforcing compile-time checks.  
- 🧩 **Code Reusability**  
  - Write once, use with multiple data types.  
- 🔗 **Performance**  
  - Avoids boxing/unboxing for value types.  
- 🛠️ **Simplified Code**  
  - Reduces code duplication and improves maintainability.  
- 🔍 **Flexibility**  
  - Works with collections, algorithms, and custom types.

---

## ❓ WHAT PROBLEM IT SOLVES
- 🚫 **Avoids Code Duplication**  
  - Eliminates the need to write separate classes for each type.  
- 🧩 **Prevents Runtime Errors**  
  - Ensures type safety at compile time.  
- 🔁 **Improves Performance**  
  - Avoids boxing/unboxing overhead for value types.

---

## 🔑 ADDITIONAL KEY POINTS
- 🔧 **Generic Constraints**  
  - Restrict the types that can be used with generics (e.g., `where`).  
- 🌀 **Generic Collections**  
  - Built-in collections like `List<T>`, `Dictionary<TKey, TValue>`.  
- ⚖️ **Comparison with Non-Generic Collections**  
  - Generics avoid type casting and improve performance.  
- 🔗 **Generic Methods**  
  - Methods that operate on parameters of type `T`.  
- 🛠️ **Generic Delegates**  
  - Delegates like `Func<T>`, `Action<T>` for type-safe callbacks.

---

## 🔍 TYPES OF GENERICS IN C#
1️⃣ **Generic Classes**  
   - Classes with type parameters (e.g., `class MyClass<T>`).  
2️⃣ **Generic Methods**  
   - Methods with type parameters (e.g., `void Print<T>(T value)`).  
3️⃣ **Generic Interfaces**  
   - Interfaces with type parameters (e.g., `IEnumerable<T>`).  
4️⃣ **Generic Delegates**  
   - Delegates with type parameters (e.g., `Func<T>`, `Action<T>`).  
5️⃣ **Generic Constraints**  
   - Restrict types using `where` clause (e.g., `where T : class`).

---

## 🔷 STEPS TO WORK WITH GENERICS
1️⃣ **Define a Generic Class**  
   - `class MyClass<T> { public T Value; }`  
2️⃣ **Instantiate with a Specific Type**  
   - `MyClass<int> obj = new MyClass<int>();`  
3️⃣ **Use Generic Methods**  
   - `void Print<T>(T value) { Console.WriteLine(value); }`  
4️⃣ **Apply Constraints**  
   - `where T : class` or `where T : new()`  
5️⃣ **Use Built-in Generic Collections**  
   - `List<int> numbers = new List<int>();`

---

## 🧪 📦 SUMMARY CODE BLOCK
```csharp
// Generic Class
class MyClass<T>
{
    public T Value;
}

// Generic Method
void Print<T>(T value)
{
    Console.WriteLine(value);
}

// Usage
MyClass<int> obj = new MyClass<int>();
obj.Value = 42;
Console.WriteLine(obj.Value); // Output: 42

Print<string>("Hello Generics!"); // Output: Hello Generics!
```
