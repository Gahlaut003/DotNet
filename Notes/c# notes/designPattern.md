+==================================================================================================================+
|                                 🎯 DESIGN PATTERNS IN C# (.NET) - ASCII STYLE SUMMARY                            |
+==================================================================================================================+

+------------------------------------------------------------------------------------------------+
| 🔹 CREATIONAL DESIGN PATTERNS                                                                  |
+------------------------------------------------------------------------------------------------+
| 1️⃣ Singleton                                                                                  |
| ───────────────────────────────────────────────────────────────────────────────────────────── |
| ✅ Definition: Ensures a class has only one instance and provides global access.               |
| 🎯 Why Use: To control access to shared resources (e.g., logging, DB connection).              |
| 🧪 Example:                                                                                     |
|     public sealed class Logger                                                                 |
|     {                                                                                          |
|         private static readonly Logger _instance = new Logger();                               |
|         private Logger() { }                                                                   |
|         public static Logger Instance => _instance;                                            |
|     }                                                                                          |
+------------------------------------------------------------------------------------------------+
| 2️⃣ Factory Method                                                                             |
| ✅ Definition: Lets a class defer instantiation to subclasses.                                 |
| 🎯 Why Use: For flexibility in creating objects without specifying class name.                 |
| 🧪 Example:                                                                                     |
|     abstract class Dialog { public abstract IButton CreateButton(); }                          |
|     class WindowsDialog : Dialog { public override IButton CreateButton() => new WinButton(); }|
+------------------------------------------------------------------------------------------------+
| 3️⃣ Abstract Factory                                                                           |
| ✅ Definition: Creates families of related objects without specifying classes.                 |
| 🎯 Why Use: For consistent object families (e.g., UI kits).                                    |
| 🧪 Example:                                                                                     |
|     interface IGUIFactory { IButton CreateButton(); ICheckbox CreateCheckbox(); }              |
|     class MacFactory : IGUIFactory { ... }                                                     |
+------------------------------------------------------------------------------------------------+
| 4️⃣ Builder                                                                                   |
| ✅ Definition: Builds complex objects step-by-step.                                            |
| 🎯 Why Use: For creating different representations using same process.                         |
| 🧪 Example:                                                                                     |
|     class CarBuilder { void SetEngine(); void SetWheels(); ... }                               |
+------------------------------------------------------------------------------------------------+
| 5️⃣ Prototype                                                                                 |
| ✅ Definition: Clone existing objects without depending on their classes.                      |
| 🎯 Why Use: For fast creation using pre-configured objects.                                    |
| 🧪 Example:                                                                                     |
|     public class Shape : ICloneable { public object Clone() => this.MemberwiseClone(); }       |
+------------------------------------------------------------------------------------------------+

+------------------------------------------------------------------------------------------------+
| 🔹 STRUCTURAL DESIGN PATTERNS                                                                  |
+------------------------------------------------------------------------------------------------+
| 1️⃣ Adapter                                                                                   |
| ✅ Definition: Converts one interface into another.                                            |
| 🎯 Why Use: To connect incompatible interfaces.                                                |
| 🧪 Example:                                                                                     |
|     class Adapter : ITarget { private Adaptee _adaptee; public void Request() => _adaptee.SpecificRequest(); }|
+------------------------------------------------------------------------------------------------+
| 2️⃣ Bridge                                                                                    |
| ✅ Definition: Decouples abstraction from implementation.                                      |
| 🎯 Why Use: For flexible class hierarchies.                                                    |
| 🧪 Example:                                                                                     |
|     interface IRenderer { void RenderCircle(); }                                               |
|     class VectorRenderer : IRenderer { ... }                                                   |
+------------------------------------------------------------------------------------------------+
| 3️⃣ Composite                                                                                 |
| ✅ Definition: Treats group of objects as single instance.                                     |
| 🎯 Why Use: Represent tree structures like UI or filesystems.                                  |
| 🧪 Example:                                                                                     |
|     interface IComponent { void Display(); }                                                   |
|     class Leaf : IComponent { ... }, class Composite : IComponent { List<IComponent> children }|
+------------------------------------------------------------------------------------------------+
| 4️⃣ Decorator                                                                                 |
| ✅ Definition: Adds behavior to objects at runtime.                                            |
| 🎯 Why Use: For extending functionality dynamically.                                           |
| 🧪 Example:                                                                                     |
|     class Text : IComponent { }                                                                |
|     class BoldDecorator : IComponent { private IComponent _inner; }                            |
+------------------------------------------------------------------------------------------------+
| 5️⃣ Facade                                                                                   |
| ✅ Definition: Provides simplified interface to complex subsystem.                             |
| 🎯 Why Use: Simplify client interaction.                                                       |
| 🧪 Example:                                                                                     |
|     class CompilerFacade { void Compile() => lexer.Parse(); parser.Analyze(); }                |
+------------------------------------------------------------------------------------------------+
| 6️⃣ Flyweight                                                                                 |
| ✅ Definition: Reuses shared objects to save memory.                                           |
| 🎯 Why Use: High volume, similar object reuse (e.g., game sprites).                            |
| 🧪 Example:                                                                                     |
|     class TreeFactory { Dictionary<string, TreeType> _cache; }                                 |
+------------------------------------------------------------------------------------------------+
| 7️⃣ Proxy                                                                                     |
| ✅ Definition: Provides placeholder to control access.                                         |
| 🎯 Why Use: Add lazy loading, logging, or access control.                                      |
| 🧪 Example:                                                                                     |
|     class ProxyImage : IImage { private RealImage _real; void Display() => _real.Display(); }  |
+------------------------------------------------------------------------------------------------+

+------------------------------------------------------------------------------------------------+
| 🔹 BEHAVIORAL DESIGN PATTERNS                                                                  |
+------------------------------------------------------------------------------------------------+
| 1️⃣ Strategy                                                                                 |
| ✅ Definition: Encapsulates interchangeable behaviors.                                         |
| 🎯 Why Use: To switch algorithms dynamically.                                                  |
| 🧪 Example:                                                                                     |
|     interface ISort { void Sort(); }                                                           |
|     class QuickSort : ISort { ... }                                                            |
+------------------------------------------------------------------------------------------------+
| 2️⃣ State                                                                                    |
| ✅ Definition: Changes object behavior when state changes.                                     |
| 🎯 Why Use: For state-dependent behavior.                                                      |
| 🧪 Example:                                                                                     |
|     class Context { State _state; void Request() => _state.Handle(); }                         |
+------------------------------------------------------------------------------------------------+
| 3️⃣ Command                                                                                  |
| ✅ Definition: Encapsulates a request as an object.                                            |
| 🎯 Why Use: For undo, redo, and command queues.                                                |
| 🧪 Example:                                                                                     |
|     class LightOnCommand : ICommand { void Execute() => light.On(); }                          |
+------------------------------------------------------------------------------------------------+
| 4️⃣ Chain of Responsibility                                                                  |
| ✅ Definition: Passes request along handlers.                                                  |
| 🎯 Why Use: Decouple sender and receiver.                                                      |
| 🧪 Example:                                                                                     |
|     class Handler { Handler next; void Handle(Request req) => next?.Handle(req); }             |
+------------------------------------------------------------------------------------------------+
| 5️⃣ Mediator                                                                                 |
| ✅ Definition: Central object coordinates interactions.                                        |
| 🎯 Why Use: Reduce direct object references.                                                   |
| 🧪 Example:                                                                                     |
|     class ChatRoom : IMediator { void Send() => user.Receive(); }                              |
+------------------------------------------------------------------------------------------------+
| 6️⃣ Observer                                                                                 |
| ✅ Definition: Notifies observers when subject changes.                                        |
| 🎯 Why Use: Event-driven systems.                                                              |
| 🧪 Example:                                                                                     |
|     class Subject { List<IObserver> _obs; void Notify() => _obs.ForEach(o => o.Update()); }    |
+------------------------------------------------------------------------------------------------+
| 7️⃣ Visitor                                                                                  |
| ✅ Definition: Adds operation without modifying structure.                                     |
| 🎯 Why Use: For extending complex structures.                                                  |
| 🧪 Example:                                                                                     |
|     interface IVisitor { void Visit(ElementA a); }                                              |
|     class ElementA { void Accept(IVisitor visitor) => visitor.Visit(this); }                   |
+------------------------------------------------------------------------------------------------+
| 8️⃣ Template Method                                                                          |
| ✅ Definition: Defines skeleton of algorithm in superclass.                                    |
| 🎯 Why Use: To reuse structure but allow override steps.                                       |
| 🧪 Example:                                                                                     |
|     abstract class DataParser { void Parse() => Load(); Process(); Save(); }                   |
+------------------------------------------------------------------------------------------------+
| 9️⃣ Iterator                                                                                 |
| ✅ Definition: Provides a way to access collection elements sequentially.                      |
| 🎯 Why Use: For exposing elements without exposing internal structure.                         |
| 🧪 Example:                                                                                     |
|     class MyIterator : IEnumerator { ... }                                                     |
+------------------------------------------------------------------------------------------------+
| 🔟 Memento                                                                                   |
| ✅ Definition: Captures and restores object state.                                             |
| 🎯 Why Use: Undo mechanisms.                                                                   |
| 🧪 Example:                                                                                     |
|     class Editor { SaveState() => new Memento(); Restore(m) => ... }                           |
+------------------------------------------------------------------------------------------------+
| 1️⃣1️⃣ Interpreter                                                                           |
| ✅ Definition: Implements grammar interpreter.                                                 |
| 🎯 Why Use: For custom scripting or expression evaluators.                                     |
| 🧪 Example:                                                                                     |
|     class Context { Dictionary<string, bool> Vars; }                                           |
|     class VariableExpression : IExpression { Evaluate(ctx) => ctx.Vars["x"]; }                 |
+------------------------------------------------------------------------------------------------+

+==================================================================================================================+
| ✅ Summary:                                                                                                      |
| - Use Creational patterns to abstract object creation.                                                          |
| - Use Structural patterns to simplify relationships between objects.                                            |
| - Use Behavioral patterns to manage object communication and workflow.                                          |
+==================================================================================================================+
