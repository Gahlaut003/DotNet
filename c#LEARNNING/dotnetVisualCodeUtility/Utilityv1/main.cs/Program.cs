public interface IAnimal
{
    void Speak();   // Method declaration
    string Name { get; set; }  // Property declaration
}


public class Dog : IAnimal
{
    public string Name { get; set; }  // Implementing the property

    public void Speak()  // Implementing the method
    {
        Console.WriteLine("Woof!");
    }
}
