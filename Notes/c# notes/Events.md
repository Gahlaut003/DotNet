# 🔹 EVENTS

## ✅ DEFINITION
A mechanism for communication between objects.  
Built on top of delegates, enabling the publish-subscribe pattern.  
Allows one-to-many method invocation.

**🔖 Official Definition (Microsoft):**  
"An event is a message sent by an object to signal the occurrence of an action. The action could be caused by user interaction, program logic, or some other source."

---

## 🎯 WHY WE USE EVENTS - BENEFITS & SCENARIOS
- 🔁 **Decoupling Publishers and Subscribers**  
  - Publishers raise events without knowing subscribers.  
  - Subscribers handle events independently.  
- 🧩 **Notification Mechanism**  
  - Core for UI frameworks, reactive programming, and notifications.  
  - Enables dynamic response to state changes.  
- 🔗 **Extensibility**  
  - Allows adding/removing handlers dynamically.  
  - Promotes modular and reusable code.

---

## ❓ WHAT PROBLEM IT SOLVES
- 🚫 **Avoids Tight Coupling**  
  - Publishers don’t need to know about subscribers.  
- 🧩 **Enables Reactive Programming**  
  - Objects can react to changes dynamically.  
- 🔁 **Promotes Inversion of Control (IoC)**  
  - Subscribers decide how to handle events.

---

## 🔑 ADDITIONAL KEY POINTS
- 🔧 **Events vs Delegates**  
  - Events restrict direct invocation by external code.  
  - Delegates allow direct invocation.  
- 🌀 **Event Accessors**  
  - Add/remove handlers using `+=` and `-=`.  
  - Custom accessors can be defined for advanced scenarios.  
- ⚖️ **Multicast Behavior**  
  - Events can have multiple subscribers.  
  - All handlers are invoked in order of addition.

---

## 🔍 TYPES OF EVENTS IN C#
1️⃣ **Standard Events**  
   - Events declared using the `event` keyword and a delegate type.  
2️⃣ **Custom Events**  
   - Events with custom add/remove accessors for advanced scenarios.  
3️⃣ **Multicast Events**  
   - Events that allow multiple subscribers.  
4️⃣ **Static Events**  
   - Events declared as `static`, shared across all instances of a class.  
5️⃣ **Generic Events**  
   - Events using generic delegate types like `EventHandler<T>`.

---

## 🔷 STEPS TO WORK WITH EVENTS
1️⃣ **Declare an Event**  
   - `public event EventHandler MyEvent;`  
2️⃣ **Subscribe to an Event**  
   - `MyEvent += HandlerMethod;`  
3️⃣ **Raise an Event**  
   - `MyEvent?.Invoke(this, EventArgs.Empty);`  
4️⃣ **Unsubscribe from an Event**  
   - `MyEvent -= HandlerMethod;`

---

## 🧪 📦 SUMMARY CODE BLOCK
```csharp
public class Publisher
{
    public event EventHandler MyEvent;
    public void RaiseEvent()
    {
        MyEvent?.Invoke(this, EventArgs.Empty);
    }
}

public class Subscriber
{
    public void OnEventRaised(object sender, EventArgs e)
    {
        Console.WriteLine("Event received!");
    }
}

Publisher publisher = new Publisher();
Subscriber subscriber = new Subscriber();
publisher.MyEvent += subscriber.OnEventRaised;
publisher.RaiseEvent();
// Output: Event received!
```
