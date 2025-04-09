# Object-Oriented Programming (OOP)

## Classes and Objects
A **class** is a blueprint or template for creating objects. It defines the structure and behavior (data and methods) that the objects created from the class will have. A class encapsulates data for the object and methods to manipulate that data.

### Official Definition
In C#, a **class** is defined as a data structure that encapsulates data and behavior. It is declared using the `class` keyword and can include fields, properties, methods, events, and other class types. Classes support inheritance, polymorphism, and encapsulation, which are the core principles of object-oriented programming.

### Components of a Class
1. **Fields**: Variables that hold the data or state of the class.
   - Example: `private int age;`

2. **Properties**: Provide controlled access to the fields. They can include logic for getting and setting values.
   - Example:
     ```csharp
     public int Age {
         get { return age; }
         set { age = value; }
     }
     ```

3. **Methods**: Define the behavior or functionality of the class.
   - Example:
     ```csharp
     public void DisplayAge() {
         Console.WriteLine($"Age: {age}");
     }
     ```

4. **Constructors**: Special methods used to initialize objects of the class. They can be parameterized or parameterless.
   - Example:
     ```csharp
     public Person(int age) {
         this.age = age;
     }
     ```

5. **Destructors**: Used to clean up resources when an object is no longer needed. They are rarely used in modern C# due to garbage collection.
   - Example:
     ```csharp
     ~Person() {
         // Cleanup code
     }
     ```

6. **Events**: Allow a class to notify other classes or objects when something of interest happens.
   - Example:
     ```csharp
     public event EventHandler AgeChanged;
     ```

7. **Nested Classes**: Classes defined within another class. They are used to logically group classes that are only used in one place.
   - Example:
     ```csharp
     public class OuterClass {
         public class InnerClass {
             // Inner class code
         }
     }
     ```

 ### Example of a Class
```csharp
public class Person {
    // Fields
    private string name;
    private int age;

    // Properties
    public string Name {
        get { return name; }
        set { name = value; }
    }

    public int Age {
        get { return age; }
        set { age = value; }
    }

    // Constructor
    public Person(string name, int age) {
        this.name = name;
        this.age = age;
    }

    // Method
    public void Introduce() {
        Console.WriteLine($"Hi, I'm {name} and I'm {age} years old.");
    }
}
```    

### Access Modifiers
Access modifiers define the visibility of the class and its members:
- `public`: Accessible from anywhere.
  *   **Accessibility**: Accessible from anywhere, without any restrictions.
  *   **Usage**: Use `public` when you want a class or member to be accessible from any part of your code, including other assemblies (projects).
  *   **Example**:
        ```csharp
        public class MyClass
        {
            public int PublicField; // Accessible from anywhere
            public void PublicMethod() { } // Accessible from anywhere
        }
        ```
- `private`: Accessible only within the class.
  *   **Accessibility**: Accessible only within the class in which it is declared.
  *   **Usage**: Use `private` to encapsulate data and hide implementation details from outside the class. This is a key part of encapsulation.
  *   **Example**:
        ```csharp
        public class MyClass
        {
            private int privateField; // Accessible only within MyClass
            private void PrivateMethod() { } // Accessible only within MyClass
        }
        ```
- `protected`: Accessible within the class and derived classes.
  *   **Accessibility**: Accessible within the class in which it is declared and by derived classes (subclasses), even if they are in different assemblies.
  *   **Usage**: Use `protected` when you want members to be accessible to subclasses but not to arbitrary code outside the class hierarchy.
  *   **Example**:
        ```csharp
        public class MyClass
        {
            protected int ProtectedField; // Accessible within MyClass and derived classes
            protected void ProtectedMethod() { } // Accessible within MyClass and derived classes
        }

        public class DerivedClass : MyClass
        {
            public void AccessProtected()
            {
                ProtectedField = 10; // OK: Accessible in derived class
                ProtectedMethod(); // OK: Accessible in derived class
            }
        }
        ```
- `internal`: Accessible within the same assembly.
  *   **Accessibility**: Accessible only within the same assembly (project).
  *   **Usage**: Use `internal` when you want a class or member to be accessible throughout your project but not from other projects.
  *   **Example**:
        ```csharp
        internal class MyClass // Accessible only within the same assembly
        {
            internal int InternalField; // Accessible only within the same assembly
            internal void InternalMethod() { } // Accessible only within the same assembly
        }
        ```
- `protected internal`: Accessible within the same assembly or derived classes.
  *   **Accessibility**: Accessible within the same assembly and by derived classes in other assemblies. It's the union of `protected` and `internal`.
  *   **Usage**: Use `protected internal` when you want a member to be accessible to derived classes, regardless of which assembly they are in, and to any code within the same assembly.
  *   **Example**:
        ```csharp
        public class MyClass
        {
            protected internal int ProtectedInternalField; // Accessible within the same assembly or derived classes
            protected internal void ProtectedInternalMethod() { } // Accessible within the same assembly or derived classes
        }
        ```
<!-- filepath: c:\Users\Abhishek\Documents\learning\C#\Notes\c# notes\OOP\OOP.md -->




## Types of Classes in C#.Net
1. **Abstract Class**: 
   - An abstract class is a class that cannot be instantiated directly. It is designed to be a base class for other classes.
   - It can include abstract methods (methods without implementation) and concrete methods (methods with implementation).
   - Example:
     ```csharp
     public abstract class Shape {
         public abstract void Draw(); // Abstract method
         public void Display() {
             Console.WriteLine("Displaying shape");
         }
     }
     ```

2. **Partial Class**:
   - A partial class allows its definition to be split across multiple files. All parts are combined into a single class when compiled.
   - Useful for organizing large classes or auto-generated code.
   - Example:
     ```csharp
     // File1.cs
     public partial class MyClass {
         public void Method1() {
             Console.WriteLine("Method1");
         }
     }

     // File2.cs
     public partial class MyClass {
         public void Method2() {
             Console.WriteLine("Method2");
         }
     }
     ```

3. **Sealed Class**:
   - A sealed class cannot be inherited. It is used to prevent further derivation.
   - Example:
     ```csharp
     public sealed class FinalClass {
         public void Display() {
             Console.WriteLine("This is a sealed class.");
         }
     }
     ```

4. **Static Class**:
   - A static class cannot be instantiated and can only contain static members (fields, methods, properties, etc.).
   - It is used for utility or helper methods.
   - Example:
     ```csharp
     public static class MathHelper {
         public static int Add(int a, int b) {
             return a + b;
         }
     }
     ```

## OOP Principles
The principles of Object-Oriented Programming (OOP) are the foundation of designing and implementing software using the object-oriented paradigm. These principles ensure modularity, reusability, and maintainability of code.

### 1. **Abstraction**
   - **Official Definition**: Abstraction is the process of hiding the implementation details and showing only the essential features of an object.
   - **Why We Use**: It reduces complexity by focusing on what an object does instead of how it does it.
   - **Types**:
     - Abstract Classes
     - Interfaces
   - **Example**:
     ```csharp
     public interface IAnimal {
         void MakeSound(); // Interface method
     }

     public class Dog : IAnimal {
         public void MakeSound() {
             Console.WriteLine("Bark");
         }
     }
     ```

### 2. **Encapsulation**
   - **Official Definition**: Encapsulation is the process of bundling data (fields) and methods that operate on the data into a single unit (class) and restricting direct access to some of the object's components.
   - **Why We Use**: It protects the integrity of the data by preventing unauthorized access and modification.
   - **Components**:
     - Access Modifiers (`private`, `public`, `protected`, etc.)
     - Properties for controlled access
   - **Example**:
     ```csharp
     public class BankAccount {
         private decimal balance;

         public decimal Balance {
             get { return balance; }
             private set { balance = value; }
         }

         public void Deposit(decimal amount) {
             if (amount > 0) {
                 balance += amount;
             }
         }
     }
     ```

### 3. **Polymorphism**
   - **Official Definition**: Polymorphism allows objects to be treated as instances of their parent class rather than their actual class. It enables one interface to be used for a general class of actions.
   - **Why We Use**: It promotes flexibility and reusability by allowing the same method to behave differently based on the object.
   - **Types**:
     - Compile-Time Polymorphism (Method Overloading)
     - Run-Time Polymorphism (Method Overriding)
   - **Example**:
     ```csharp
     // Method Overloading (Compile-Time Polymorphism)
     public class Calculator {
         public int Add(int a, int b) {
             return a + b;
         }

         public double Add(double a, double b) {
             return a + b;
         }
     }

     // Method Overriding (Run-Time Polymorphism)
     public class Animal {
         public virtual void Speak() {
             Console.WriteLine("Animal speaks");
         }
     }

     public class Cat : Animal {
         public override void Speak() {
             Console.WriteLine("Meow");
         }
     }
     ```

### 4. **Inheritance**
   - **Official Definition**: Inheritance is the mechanism by which one class (child class) can inherit the properties and methods of another class (parent class).
   - **Why We Use**: It promotes code reuse and establishes a relationship between classes.
   - **Types**:
     - Single Inheritance
     - Multilevel Inheritance
     - Hierarchical Inheritance
     - (C# does not support multiple inheritance directly but allows it through interfaces.)
   - **Example**:
     ```csharp
     public class Vehicle {
         public void Start() {
             Console.WriteLine("Vehicle started");
         }
     }

     public class Car : Vehicle {
         public void Drive() {
             Console.WriteLine("Car is driving");
         }
     }
     ```

## Relationships in OOP
Relationships in OOP define how objects and classes interact with each other. These relationships are essential for designing modular and reusable systems.

### 1. **Dependency**
   - **Definition**: A dependency relationship exists when one class depends on another class to function. This is often a "uses-a" relationship.
   - **Why We Use**: It allows one class to use the functionality of another without tightly coupling them.
   - **Example**:
     ```csharp
     public class Logger {
         public void Log(string message) {
             Console.WriteLine($"Log: {message}");
         }
     }

     public class OrderProcessor {
         private Logger logger = new Logger();

         public void ProcessOrder() {
             logger.Log("Order processed.");
         }
     }
     ```

### 2. **Generalization**
   - **Definition**: Generalization is the process of extracting shared characteristics from two or more classes and creating a generalized superclass. This is an "is-a" relationship.
   - **Why We Use**: It promotes code reuse and establishes a hierarchy between classes.
   - **Example**:
     ```csharp
     public class Animal {
         public void Eat() {
             Console.WriteLine("Eating...");
         }
     }

     public class Dog : Animal {
         public void Bark() {
             Console.WriteLine("Barking...");
         }
     }
     ```

### 3. **Association**
   - **Definition**: Association is a relationship where one class is connected to another. It can be one-to-one, one-to-many, or many-to-many.
   - **Why We Use**: It models real-world relationships between objects.
   - **Types**:
     - **Unidirectional**: One class knows about the other.
     - **Bidirectional**: Both classes know about each other.
   - **Example**:
     ```csharp
     public class Teacher {
         public string Name { get; set; }
     }

     public class Student {
         public string Name { get; set; }
         public Teacher Teacher { get; set; } // Association
     }
     ```

### 4. **Aggregation**
   - **Definition**: Aggregation is a specialized form of association where one class contains another class as a part, but both can exist independently. This is a "has-a" relationship.
   - **Why We Use**: It represents a whole-part relationship without ownership.
   - **Example**:
     ```csharp
     public class Department {
         public string Name { get; set; }
     }

     public class University {
         public List<Department> Departments { get; set; } = new List<Department>();
     }
     ```

### 5. **Composition**
   - **Definition**: Composition is a stronger form of aggregation where one class owns another class, and the contained class cannot exist without the container class.
   - **Why We Use**: It ensures a strict lifecycle dependency between the container and the contained objects.
   - **Example**:
     ```csharp
     public class Engine {
         public void Start() {
             Console.WriteLine("Engine started.");
         }
     }

     public class Car {
         private Engine engine = new Engine(); // Composition

         public void StartCar() {
             engine.Start();
             Console.WriteLine("Car started.");
         }
     }
     ```

## Advanced Concepts

### 1. **Generics**
   - **Definition**: Generics allow you to define classes, methods, and interfaces with a placeholder for the type of data they store or use. This enables type safety and code reusability.
   - **Why We Use**:
     - To create reusable and type-safe data structures or methods.
     - To avoid runtime errors by catching type mismatches at compile time.
   - **Components**:
     - Generic Classes
     - Generic Methods
     - Generic Interfaces
   - **Example**:
     ```csharp
     // Generic Class
     public class GenericList<T> {
         private List<T> items = new List<T>();

         public void Add(T item) {
             items.Add(item);
         }

         public T Get(int index) {
             return items[index];
         }
     }

     // Usage
     GenericList<int> intList = new GenericList<int>();
     intList.Add(10);
     Console.WriteLine(intList.Get(0)); // Output: 10
     ```

### 2. **Delegates**
   - **Definition**: A delegate is a type that represents references to methods with a specific signature. Delegates are used to pass methods as arguments to other methods.
   - **Why We Use**:
     - To implement callbacks.
     - To enable event-driven programming.
     - To achieve loose coupling between components.
   - **Types**:
     - Single-Cast Delegate: Refers to a single method.
     - Multi-Cast Delegate: Refers to multiple methods.
   - **Example**:
     ```csharp
     // Delegate Declaration
     public delegate void Notify(string message);

     // Class with a Method Matching the Delegate Signature
     public class Notifier {
         public void SendNotification(string message) {
             Console.WriteLine($"Notification: {message}");
         }
     }

     // Usage
     Notifier notifier = new Notifier();
     Notify notifyDelegate = new Notify(notifier.SendNotification);
     notifyDelegate("Hello, Delegates!"); // Output: Notification: Hello, Delegates!
     ```
