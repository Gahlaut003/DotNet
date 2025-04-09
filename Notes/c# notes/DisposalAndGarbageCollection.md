# 🔹 DISPOSAL AND GARBAGE COLLECTION

## ✅ DEFINITION
Disposal is the process of releasing unmanaged resources explicitly.  
Garbage Collection (GC) is an automatic memory management feature in .NET that reclaims unused managed objects.

**🔖 Official Definition (Microsoft):**  
"Garbage Collection is the process of automatically reclaiming memory occupied by objects that are no longer accessible."

---

## 🎯 WHY WE USE DISPOSAL AND GARBAGE COLLECTION - BENEFITS & SCENARIOS
- 🔁 **Automatic Memory Management**  
  - Reduces developer effort by handling memory cleanup.  
- 🧩 **Resource Optimization**  
  - Frees unused memory, improving application performance.  
- 🔗 **Explicit Resource Management**  
  - `IDisposable` allows manual cleanup of unmanaged resources.  
- 🛠️ **Prevents Memory Leaks**  
  - Ensures objects are properly disposed when no longer needed.  
- 🔍 **Finalization for Unmanaged Resources**  
  - Finalizers (`~ClassName`) handle cleanup for unmanaged resources.

---

## ❓ WHAT PROBLEM IT SOLVES
- 🚫 **Prevents Resource Leaks**  
  - Ensures proper cleanup of unmanaged resources like file handles.  
- 🧩 **Simplifies Memory Management**  
  - Automates memory allocation and deallocation.  
- 🔁 **Improves Application Stability**  
  - Reduces crashes caused by memory exhaustion.

---

## 🔑 ADDITIONAL KEY POINTS
- 🔧 **IDisposable Interface**  
  - Implement `Dispose` method for explicit resource cleanup.  
- 🌀 **Finalizers**  
  - Used for cleanup when `Dispose` is not called explicitly.  
- ⚖️ **GC Generations**  
  - Objects are categorized into Gen 0, Gen 1, and Gen 2 for GC.  
- 🔗 **Suppress Finalization**  
  - Use `GC.SuppressFinalize` to prevent redundant finalization.  
- 🛠️ **Weak References**  
  - Allow access to objects without preventing their collection.

---

## 🔍 TYPES OF GARBAGE COLLECTION IN C#
1️⃣ **Workstation GC**  
   - Optimized for single-threaded applications.  
2️⃣ **Server GC**  
   - Optimized for multi-threaded, high-performance applications.  
3️⃣ **Concurrent GC**  
   - Runs alongside application threads to minimize pauses.  
4️⃣ **Background GC**  
   - Improves performance by running in the background.

---

## 🔷 STEPS TO WORK WITH DISPOSAL
1️⃣ **Implement IDisposable Interface**  
   - `public void Dispose() { /* Cleanup logic */ }`  
2️⃣ **Use `using` Statement**  
   - `using (var resource = new Resource()) { /* Use resource */ }`  
3️⃣ **Suppress Finalization**  
   - `GC.SuppressFinalize(this);`  
4️⃣ **Monitor GC Events**  
   - Use `GC.Collect()` and `GC.GetTotalMemory()` for diagnostics.  
5️⃣ **Avoid Overusing Finalizers**  
   - Use finalizers only when necessary for unmanaged resources.

---

## 🧪 📦 SUMMARY CODE BLOCK
```csharp
using System;

class Resource : IDisposable
{
    public void Dispose()
    {
        Console.WriteLine("Resource disposed.");
    }
}

using (var resource = new Resource())
{
    Console.WriteLine("Using resource.");
}

// Output:
// Using resource.
// Resource disposed.
```
