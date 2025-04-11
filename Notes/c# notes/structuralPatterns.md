+==================================================================================================================+
|                                 🎯 STRUCTURAL DESIGN PATTERNS IN C# (.NET)                                       |
+==================================================================================================================+

+------------------------------------------------------------------------------------------------+
| 1️⃣ Adapter                                                                                   |
| ✅ Definition: Converts one interface into another to make them compatible.                   |
| 🎯 Mechanism: Wraps an existing class with a new interface.                                   |
| 🎯 Why Use: To connect incompatible interfaces.                                                |
| 🎯 Importance: Enables reuse of existing functionality without modifying it.                  |
| 🎯 When to Use: When you need to integrate a class with an incompatible interface.            |
| 🧪 Example:                                                                                     |
|     interface ITarget { void Request(); }                                                     |
|     class Adaptee { public void SpecificRequest() { ... } }                                   |
|     class Adapter : ITarget {                                                                 |
|         private Adaptee _adaptee;                                                             |
|         public Adapter(Adaptee adaptee) { _adaptee = adaptee; }                               |
|         public void Request() => _adaptee.SpecificRequest();                                  |
|     }                                                                                         |
+------------------------------------------------------------------------------------------------+
| 2️⃣ Bridge                                                                                    |
| ✅ Definition: Decouples abstraction from implementation, allowing them to vary independently.|
| 🎯 Mechanism: Uses composition to delegate implementation to another object.                  |
| 🎯 Why Use: For flexible class hierarchies.                                                    |
| 🎯 Importance: Reduces coupling between abstraction and implementation.                       |
| 🎯 When to Use: When you need to extend both abstraction and implementation hierarchies.      |
| 🧪 Example:                                                                                     |
|     interface IRenderer { void RenderCircle(); }                                               |
|     class VectorRenderer : IRenderer { public void RenderCircle() { ... } }                   |
|     class Circle {                                                                             |
|         private IRenderer _renderer;                                                          |
|         public Circle(IRenderer renderer) { _renderer = renderer; }                           |
|         public void Draw() => _renderer.RenderCircle();                                        |
|     }                                                                                         |
+------------------------------------------------------------------------------------------------+
| 3️⃣ Composite                                                                                 |
| ✅ Definition: Treats individual objects and compositions of objects uniformly.               |
| 🎯 Mechanism: Defines a common interface for leaf and composite nodes.                        |
| 🎯 Why Use: Represent tree structures like UI or filesystems.                                  |
| 🎯 Importance: Simplifies client code by treating all objects uniformly.                      |
| 🎯 When to Use: When dealing with hierarchical structures.                                     |
| 🧪 Example:                                                                                     |
|     interface IComponent { void Display(); }                                                   |
|     class Leaf : IComponent { public void Display() { ... } }                                 |
|     class Composite : IComponent {                                                           |
|         private List<IComponent> _children = new List<IComponent>();                          |
|         public void Add(IComponent component) => _children.Add(component);                    |
|         public void Display() { foreach (var child in _children) child.Display(); }           |
|     }                                                                                         |
+------------------------------------------------------------------------------------------------+
| 4️⃣ Decorator                                                                                 |
| ✅ Definition: Adds behavior to objects dynamically without altering their structure.         |
| 🎯 Mechanism: Wraps the original object with a new object that adds functionality.            |
| 🎯 Why Use: For extending functionality dynamically.                                           |
| 🎯 Importance: Promotes open/closed principle.                                                |
| 🎯 When to Use: When you need to add responsibilities to objects at runtime.                  |
| 🧪 Example:                                                                                     |
|     interface IComponent { void Operation(); }                                                |
|     class Text : IComponent { public void Operation() { ... } }                               |
|     class BoldDecorator : IComponent {                                                       |
|         private IComponent _inner;                                                           |
|         public BoldDecorator(IComponent inner) { _inner = inner; }                           |
|         public void Operation() { _inner.Operation(); /* Add bold behavior */ }              |
|     }                                                                                         |
+------------------------------------------------------------------------------------------------+
| 5️⃣ Facade                                                                                   |
| ✅ Definition: Provides a simplified interface to a complex subsystem.                        |
| 🎯 Mechanism: Creates a higher-level interface that delegates calls to subsystem components.  |
| 🎯 Why Use: Simplify client interaction.                                                       |
| 🎯 Importance: Reduces complexity and dependencies.                                           |
| 🎯 When to Use: When working with complex subsystems.                                         |
| 🧪 Example:                                                                                     |
|     class CompilerFacade {                                                                   |
|         private Lexer lexer = new Lexer();                                                   |
|         private Parser parser = new Parser();                                                |
|         public void Compile() { lexer.Parse(); parser.Analyze(); }                           |
|     }                                                                                         |
+------------------------------------------------------------------------------------------------+
| 6️⃣ Flyweight                                                                                 |
| ✅ Definition: Reuses shared objects to save memory.                                           |
| 🎯 Mechanism: Stores shared objects in a pool and provides them on demand.                    |
| 🎯 Why Use: High volume, similar object reuse (e.g., game sprites).                            |
| 🎯 Importance: Reduces memory usage and improves performance.                                 |
| 🎯 When to Use: When many objects share common data.                                          |
| 🧪 Example:                                                                                     |
|     class TreeType { public string Name; public string Color; }                               |
|     class TreeFactory {                                                                       |
|         private Dictionary<string, TreeType> _cache = new Dictionary<string, TreeType>();    |
|         public TreeType GetTreeType(string name, string color) {                              |
|             if (!_cache.ContainsKey(name)) _cache[name] = new TreeType { Name = name, Color = color }; |
|             return _cache[name];                                                             |
|         }                                                                                     |
|     }                                                                                         |
+------------------------------------------------------------------------------------------------+
| 7️⃣ Proxy                                                                                     |
| ✅ Definition: Provides a placeholder to control access to another object.                   |
| 🎯 Mechanism: Implements the same interface as the real object and delegates calls.           |
| 🎯 Why Use: Add lazy loading, logging, or access control.                                      |
| 🎯 Importance: Adds control and flexibility to object access.                                |
| 🎯 When to Use: When you need to control access to an object.                                 |
| 🧪 Example:                                                                                     |
|     interface IImage { void Display(); }                                                     |
|     class RealImage : IImage { public void Display() { ... } }                               |
|     class ProxyImage : IImage {                                                              |
|         private RealImage _realImage;                                                        |
|         public void Display() {                                                              |
|             if (_realImage == null) _realImage = new RealImage();                            |
|             _realImage.Display();                                                           |
|         }                                                                                     |
|     }                                                                                         |
+------------------------------------------------------------------------------------------------+

+==================================================================================================================+
|                                 📖 HIGH-LEVEL TERMS DEFINED                                                      |
+==================================================================================================================+
| 1️⃣ Interface: A contract that defines a set of methods without implementation.                                  |
| 2️⃣ Abstraction: The process of hiding implementation details and showing only essential features.              |
| 3️⃣ Composition: A design principle where objects are composed of other objects to achieve functionality.       |
| 4️⃣ Open/Closed Principle: A class should be open for extension but closed for modification.                    |
| 5️⃣ Lazy Loading: A design pattern that defers initialization of an object until it is needed.                  |
+==================================================================================================================+
