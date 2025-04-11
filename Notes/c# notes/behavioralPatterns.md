+================================================================================================+
|                                 🎯 BEHAVIORAL DESIGN PATTERNS IN C# (.NET)                     |
+================================================================================================+

+------------------------------------------------------------------------------------------------+
| 1️⃣ Strategy                                                                                 |
| ✅ Official Definition: Defines a family of algorithms, encapsulates each one, and makes them interchangeable. |
| ✅ Definition: Encapsulates interchangeable behaviors and allows them to be selected at runtime.|
| 🎯 Mechanism: Defines a family of algorithms, encapsulates each one, and makes them interchangeable.|
| 🎯 Why Use: To switch algorithms dynamically.                                                  |
| 🎯 Importance: Promotes open/closed principle and reduces code duplication.                   |
| 🎯 When to Use: When multiple algorithms are needed for a task.                               |
| 🧪 Example:                                                                                     |
|     interface ISort { void Sort(); }                                                           |
|     class QuickSort : ISort { public void Sort() { /* QuickSort logic */ } }                  |
|     class BubbleSort : ISort { public void Sort() { /* BubbleSort logic */ } }                |
|     class SortContext {                                                                       |
|         private ISort _strategy;                                                             |
|         public SortContext(ISort strategy) { _strategy = strategy; }                         |
|         public void ExecuteSort() => _strategy.Sort();                                       |
|     }                                                                                         |
+------------------------------------------------------------------------------------------------+
| 2️⃣ State                                                                                    |
| ✅ Official Definition: Allows an object to alter its behavior when its internal state changes. The object will appear to change its class. |
| ✅ Definition: Allows an object to alter its behavior when its internal state changes.         |
| 🎯 Mechanism: Encapsulates state-specific behavior in separate classes and delegates state transitions.|
| 🎯 Why Use: For state-dependent behavior.                                                      |
| 🎯 Importance: Simplifies complex state transitions and promotes single responsibility.       |
| 🎯 When to Use: When an object’s behavior depends on its state.                               |
| 🧪 Example:                                                                                     |
|     interface IState { void Handle(Context context); }                                        |
|     class ConcreteStateA : IState {                                                          |
|         public void Handle(Context context) { context.State = new ConcreteStateB(); }        |
|     }                                                                                         |
|     class Context {                                                                           |
|         public IState State { get; set; }                                                    |
|         public void Request() => State.Handle(this);                                         |
|     }                                                                                         |
+------------------------------------------------------------------------------------------------+
| 3️⃣ Command                                                                                  |
| ✅ Official Definition: Encapsulates a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations. |
| ✅ Definition: Encapsulates a request as an object, allowing parameterization and queuing.    |
| 🎯 Mechanism: Defines a command interface and concrete implementations for specific actions.  |
| 🎯 Why Use: For undo, redo, and command queues.                                                |
| 🎯 Importance: Decouples sender and receiver.                                                |
| 🎯 When to Use: When you need to parameterize objects with operations.                        |
| 🧪 Example:                                                                                     |
|     interface ICommand { void Execute(); }                                                   |
|     class LightOnCommand : ICommand {                                                       |
|         private Light _light;                                                               |
|         public LightOnCommand(Light light) { _light = light; }                              |
|         public void Execute() => _light.On();                                               |
|     }                                                                                         |
|     class RemoteControl {                                                                    |
|         private ICommand _command;                                                          |
|         public void SetCommand(ICommand command) { _command = command; }                    |
|         public void PressButton() => _command.Execute();                                    |
|     }                                                                                         |
+------------------------------------------------------------------------------------------------+
| 4️⃣ Chain of Responsibility                                                                  |
| ✅ Official Definition: Avoids coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. Chains the receiving objects and passes the request along the chain until an object handles it. |
| ✅ Definition: Passes a request along a chain of handlers until one handles it.              |
| 🎯 Mechanism: Links handlers together and passes requests along the chain.                   |
| 🎯 Why Use: Decouple sender and receiver.                                                     |
| 🎯 Importance: Promotes single responsibility and flexibility.                               |
| 🎯 When to Use: When multiple handlers can process a request.                                |
| 🧪 Example:                                                                                     |
|     abstract class Handler {                                                                |
|         protected Handler _next;                                                           |
|         public void SetNext(Handler next) { _next = next; }                                 |
|         public abstract void Handle(Request req);                                           |
|     }                                                                                         |
|     class ConcreteHandlerA : Handler {                                                     |
|         public override void Handle(Request req) {                                          |
|             if (req.Type == "A") { /* Handle A */ } else { _next?.Handle(req); }            |
|         }                                                                                     |
|     }                                                                                         |
+------------------------------------------------------------------------------------------------+
| 5️⃣ Mediator                                                                                 |
| ✅ Official Definition: Defines an object that encapsulates how a set of objects interact. Mediator promotes loose coupling by keeping objects from referring to each other explicitly, and it lets you vary their interaction independently. |
| ✅ Definition: Defines an object that encapsulates how objects interact.                     |
| 🎯 Mechanism: Centralizes communication between objects through a mediator.                 |
| 🎯 Why Use: Reduce direct object references.                                                  |
| 🎯 Importance: Promotes loose coupling and simplifies communication.                        |
| 🎯 When to Use: When objects need to communicate but should not know each other.            |
| 🧪 Example:                                                                                     |
|     interface IMediator { void Notify(object sender, string event); }                       |
|     class ChatRoom : IMediator {                                                            |
|         public void Notify(object sender, string event) { /* Handle communication */ }      |
|     }                                                                                         |
|     class User {                                                                             |
|         private IMediator _mediator;                                                       |
|         public User(IMediator mediator) { _mediator = mediator; }                          |
|         public void Send(string message) => _mediator.Notify(this, message);               |
|     }                                                                                         |
+------------------------------------------------------------------------------------------------+
| 6️⃣ Observer                                                                                 |
| ✅ Official Definition: Defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically. |
| ✅ Definition: Defines a one-to-many dependency between objects.                             |
| 🎯 Mechanism: Observers register with a subject and are notified of changes.                |
| 🎯 Why Use: Event-driven systems.                                                             |
| 🎯 Importance: Promotes loose coupling and dynamic updates.                                 |
| 🎯 When to Use: When changes in one object require updates in others.                       |
| 🧪 Example:                                                                                     |
|     interface IObserver { void Update(); }                                                  |
|     class Subject {                                                                         |
|         private List<IObserver> _observers = new List<IObserver>();                        |
|         public void Attach(IObserver observer) => _observers.Add(observer);                |
|         public void Notify() => _observers.ForEach(o => o.Update());                       |
|     }                                                                                         |
+------------------------------------------------------------------------------------------------+
| 7️⃣ Visitor                                                                                  |
| ✅ Official Definition: Represents an operation to be performed on the elements of an object structure. Visitor lets you define a new operation without changing the classes of the elements on which it operates. |
| ✅ Definition: Adds new operations to objects without modifying their structure.            |
| 🎯 Mechanism: Uses a visitor object to perform operations on elements.                      |
| 🎯 Why Use: For extending complex structures.                                                 |
| 🎯 Importance: Promotes open/closed principle.                                              |
| 🎯 When to Use: When you need to perform operations on a structure of objects.              |
| 🧪 Example:                                                                                     |
|     interface IVisitor { void Visit(ElementA a); }                                          |
|     class ElementA {                                                                        |
|         public void Accept(IVisitor visitor) => visitor.Visit(this);                       |
|     }                                                                                         |
|     class ConcreteVisitor : IVisitor {                                                     |
|         public void Visit(ElementA a) { /* Perform operation */ }                          |
|     }                                                                                         |
+------------------------------------------------------------------------------------------------+
| 8️⃣ Template Method                                                                          |
| ✅ Official Definition: Defines the skeleton of an algorithm in an operation, deferring some steps to subclasses. Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure. |
| ✅ Definition: Defines the skeleton of an algorithm in a superclass.                        |
| 🎯 Mechanism: Allows subclasses to override specific steps of the algorithm.               |
| 🎯 Why Use: To reuse structure but allow override steps.                                    |
| 🎯 Importance: Promotes code reuse and consistency.                                         |
| 🎯 When to Use: When algorithms share a common structure.                                   |
| 🧪 Example:                                                                                     |
|     abstract class DataParser {                                                            |
|         public void Parse() { Load(); Process(); Save(); }                                 |
|         protected abstract void Load();                                                   |
|         protected abstract void Process();                                                |
|         protected abstract void Save();                                                   |
|     }                                                                                         |
+------------------------------------------------------------------------------------------------+
| 9️⃣ Iterator                                                                                 |
| ✅ Official Definition: Provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation. |
| ✅ Definition: Provides a way to access collection elements sequentially.                      |
| 🎯 Mechanism: Implements an iterator to traverse a collection.                              |
| 🎯 Why Use: For exposing elements without exposing internal structure.                         |
| 🎯 Importance: Promotes encapsulation and simplifies traversal.                             |
| 🎯 When to Use: When you need to traverse a collection.                                     |
| 🧪 Example:                                                                                     |
|     class MyIterator : IEnumerator {                                                       |
|         private List<int> _collection;                                                    |
|         private int _currentIndex = -1;                                                   |
|         public MyIterator(List<int> collection) { _collection = collection; }             |
|         public bool MoveNext() => ++_currentIndex < _collection.Count;                    |
|         public void Reset() => _currentIndex = -1;                                        |
|         public int Current => _collection[_currentIndex];                                 |
|     }                                                                                         |
+------------------------------------------------------------------------------------------------+
| 🔟 Memento                                                                                   |
| ✅ Official Definition: Without violating encapsulation, captures and externalizes an object's internal state so that the object can be restored to this state later. |
| ✅ Definition: Captures and restores object state.                                             |
| 🎯 Mechanism: Stores state in a memento object and restores it later.                        |
| 🎯 Why Use: Undo mechanisms.                                                                   |
| 🎯 Importance: Promotes encapsulation and simplifies state management.                      |
| 🎯 When to Use: When you need to save and restore state.                                     |
| 🧪 Example:                                                                                     |
|     class Editor {                                                                          |
|         private string _content;                                                          |
|         public Memento SaveState() => new Memento(_content);                               |
|         public void Restore(Memento memento) { _content = memento.Content; }               |
|     }                                                                                         |
|     class Memento {                                                                         |
|         public string Content { get; }                                                    |
|         public Memento(string content) { Content = content; }                              |
|     }                                                                                         |
+------------------------------------------------------------------------------------------------+
| 1️⃣1️⃣ Interpreter                                                                           |
| ✅ Official Definition: Given a language, defines a representation for its grammar along with an interpreter that uses the representation to interpret sentences in the language. |
| ✅ Definition: Implements grammar interpreter.                                                 |
| 🎯 Mechanism: Defines a grammar and uses expressions to interpret sentences.                 |
| 🎯 Why Use: For custom scripting or expression evaluators.                                     |
| 🎯 Importance: Promotes flexibility and extensibility.                                       |
| 🎯 When to Use: When you need to interpret a language or expressions.                        |
| 🧪 Example:                                                                                     |
|     interface IExpression { bool Evaluate(Context context); }                               |
|     class Context { Dictionary<string, bool> Vars; }                                        |
|     class VariableExpression : IExpression {                                                |
|         private string _name;                                                              |
|         public VariableExpression(string name) { _name = name; }                           |
|         public bool Evaluate(Context context) => context.Vars[_name];                      |
|     }                                                                                         |
+------------------------------------------------------------------------------------------------+

+================================================================================================+
|                                 📖 HIGH-LEVEL TERMS DEFINED                                    |
+================================================================================================+
| 1️⃣ Encapsulation: The bundling of data and methods that operate on the data.                                    |
| 2️⃣ Loose Coupling: Reducing dependencies between components to improve flexibility.                             |
| 3️⃣ Single Responsibility Principle: A class should have only one reason to change.                              |
| 4️⃣ Open/Closed Principle: A class should be open for extension but closed for modification.                     |
| 5️⃣ Dependency Inversion Principle: High-level modules should not depend on low-level modules.                   |
+================================================================================================+
