+==================================================================================================================+
|                                 🎯 CREATIONAL DESIGN PATTERNS IN C# (.NET)                                       |
+==================================================================================================================+

+------------------------------------------------------------------------------------------------+
| 1️⃣ Singleton                                                                                  |
| ✅ Definition:                                                                                 |
|    The Singleton pattern ensures that a class has only one instance throughout the             |
|    application lifecycle and provides a global point of access to that instance. This is       |
|    achieved by restricting the instantiation of the class to a single object. It is commonly   |
|    used to manage shared resources such as configuration settings, logging, or database        |
|    connections.                                                                                |
| ✅ Mechanism:                                                                                  |
|    - Private static field to hold the single instance.                                         |
|    - Private constructor to prevent external instantiation.                                    |
|    - Public static property or method to access the instance.                                  |
| 🎯 Why Use:                                                                                    |
|    - To control access to shared resources (e.g., logging, DB connection).                    |
| ✅ Importance:                                                                                 |
|    - Ensures a single point of control for shared resources.                                   |
|    - Reduces memory usage by avoiding multiple instances.                                      |
| 🎯 When to Use:                                                                                |
|    - When you need exactly one instance of a class (e.g., configuration manager).             |
| 🧪 Example:                                                                                     |
|     public sealed class Logger                                                                 |
|     {                                                                                          |
|         private static readonly Logger _instance = new Logger();                               |
|         private Logger() { }                                                                   |
|         public static Logger Instance => _instance;                                            |
|     }                                                                                          |
+------------------------------------------------------------------------------------------------+
| 2️⃣ Factory Method                                                                             |
| ✅ Definition:                                                                                 |
|    The Factory Method pattern defines an interface for creating objects but allows             |
|    subclasses to alter the type of objects that will be created. Instead of instantiating      |
|    objects directly, the client relies on a factory method to create the object. This          |
|    promotes loose coupling between the client and the concrete classes it depends on.          |
| ✅ Mechanism:                                                                                  |
|    - Abstract class or interface declares a factory method.                                    |
|    - Subclasses override the factory method to create specific objects.                       |
| 🎯 Why Use:                                                                                    |
|    - To achieve flexibility in creating objects without specifying their concrete classes.     |
| ✅ Importance:                                                                                 |
|    - Promotes loose coupling between client code and object creation.                         |
|    - Simplifies code maintenance and testing.                                                 |
| 🎯 When to Use:                                                                                |
|    - When the exact type of object to be created is determined at runtime.                    |
| 🧪 Example:                                                                                     |
|     abstract class Dialog { public abstract IButton CreateButton(); }                          |
|     class WindowsDialog : Dialog { public override IButton CreateButton() => new WinButton(); }|
+------------------------------------------------------------------------------------------------+
| 3️⃣ Abstract Factory                                                                           |
| ✅ Definition:                                                                                 |
|    The Abstract Factory pattern provides an interface for creating families of related or      |
|    dependent objects without specifying their concrete classes. It is particularly useful      |
|    when the system needs to ensure that a group of objects are designed to work together.      |
|    This pattern encapsulates the creation logic for a family of objects into a single          |
|    factory interface, making it easier to switch between different implementations.            |
| ✅ Mechanism:                                                                                  |
|    - Define an abstract factory interface with methods for creating each type of object.       |
|    - Implement concrete factories for specific families of objects.                           |
| 🎯 Why Use:                                                                                    |
|    - To ensure consistency among objects in a family (e.g., UI components).                   |
| ✅ Importance:                                                                                 |
|    - Simplifies the creation of related objects.                                              |
|    - Ensures compatibility between objects in a family.                                       |
| 🎯 When to Use:                                                                                |
|    - When you need to create families of related objects (e.g., cross-platform UI).           |
| 🧪 Example:                                                                                     |
|     interface IGUIFactory { IButton CreateButton(); ICheckbox CreateCheckbox(); }              |
|     class MacFactory : IGUIFactory { ... }                                                     |
+------------------------------------------------------------------------------------------------+
| 4️⃣ Builder                                                                                   |
| ✅ Definition:                                                                                 |
|    The Builder pattern separates the construction of a complex object from its representation, |
|    allowing the same construction process to create different representations. It is useful    |
|    when creating objects that require multiple steps or configurations. By using a builder,    |
|    the client can construct an object step-by-step and have greater control over the           |
|    construction process.                                                                       |
| ✅ Mechanism:                                                                                  |
|    - Define a builder interface with methods for configuring parts of the object.             |
|    - Implement concrete builders for specific representations.                                |
|    - Use a director class to control the construction process.                                |
| 🎯 Why Use:                                                                                    |
|    - To construct complex objects step-by-step.                                               |
|    - To create different representations of the same object.                                  |
| ✅ Importance:                                                                                 |
|    - Simplifies the creation of complex objects.                                              |
|    - Improves code readability and maintainability.                                           |
| 🎯 When to Use:                                                                                |
|    - When creating complex objects with many optional parts or configurations.                |
| 🧪 Example:                                                                                     |
|     class CarBuilder { void SetEngine(); void SetWheels(); ... }                               |
+------------------------------------------------------------------------------------------------+
| 5️⃣ Prototype                                                                                 |
| ✅ Definition:                                                                                 |
|    The Prototype pattern allows you to create new objects by copying an existing object,       |
|    known as the prototype. This is particularly useful when object creation is expensive       |
|    or complex. Instead of instantiating a new object from scratch, the prototype is cloned,    |
|    which can significantly improve performance and simplify object creation.                   |
| ✅ Mechanism:                                                                                  |
|    - Implement a prototype interface with a cloning method.                                   |
|    - Create new objects by copying existing ones.                                             |
| 🎯 Why Use:                                                                                    |
|    - To avoid the cost of creating objects from scratch.                                      |
|    - To create objects based on a pre-configured prototype.                                   |
| ✅ Importance:                                                                                 |
|    - Improves performance by reusing existing objects.                                        |
|    - Simplifies object creation when configuration is complex.                                |
| 🎯 When to Use:                                                                                |
|    - When object creation is expensive or time-consuming.                                     |
|    - When you need to create objects with similar configurations.                             |
| 🧪 Example:                                                                                     |
|     public class Shape : ICloneable { public object Clone() => this.MemberwiseClone(); }       |
+------------------------------------------------------------------------------------------------+

+==================================================================================================================+
|                                    📚 HIGH-LEVEL TERMS DEFINED                                                   |
+==================================================================================================================+
| 1️⃣ **Instance**:                                                                              |
|    An instance refers to a specific realization of a class. When a class is instantiated,      |
|    memory is allocated, and an object is created.                                              |
|                                                                                                |
| 2️⃣ **Global Access**:                                                                         |
|    A mechanism that allows an object or resource to be accessed from anywhere in the           |
|    application. Singleton patterns often provide global access to their single instance.       |
|                                                                                                |
| 3️⃣ **Loose Coupling**:                                                                        |
|    A design principle that reduces dependencies between components, making the system          |
|    easier to maintain, test, and extend. Factory patterns promote loose coupling by            |
|    abstracting object creation.                                                               |
|                                                                                                |
| 4️⃣ **Concrete Class**:                                                                        |
|    A class that provides an implementation for all its methods and can be instantiated.        |
|    In contrast, abstract classes or interfaces define the structure but not the                |
|    implementation.                                                                             |
|                                                                                                |
| 5️⃣ **Abstract Class**:                                                                        |
|    A class that cannot be instantiated and is meant to be inherited. It may contain            |
|    abstract methods (without implementation) and concrete methods (with implementation).       |
|                                                                                                |
| 6️⃣ **Interface**:                                                                             |
|    A contract that defines a set of methods or properties that a class must implement.         |
|    Interfaces are used to achieve abstraction and promote loose coupling.                     |
|                                                                                                |
| 7️⃣ **Cloning**:                                                                               |
|    The process of creating a copy of an object. In the Prototype pattern, cloning is           |
|    used to create new objects by copying an existing prototype object.                        |
|                                                                                                |
| 8️⃣ **Configuration**:                                                                         |
|    The process of setting up an object with specific properties or parameters. Builder         |
|    patterns are often used to handle complex configurations.                                  |
|                                                                                                |
| 9️⃣ **Cross-Platform UI**:                                                                     |
|    A user interface that works consistently across different platforms (e.g., Windows,         |
|    macOS). Abstract Factory patterns are commonly used to create cross-platform UIs.          |
|                                                                                                |
| 🔟 **Step-by-Step Construction**:                                                              |
|    A process where an object is built incrementally by configuring its parts one at a          |
|    time. This is a key feature of the Builder pattern.                                         |
+==================================================================================================================+
