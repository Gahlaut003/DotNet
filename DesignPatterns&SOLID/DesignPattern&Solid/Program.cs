// // Encapsulation

// using ConsoleApp1.src.Oop.Encapsulation;

// // BadBankAccount badBankAccount = new BadBankAccount();
// // badBankAccount.balance =100;
// // System.Console.WriteLine(badBankAccount.balance);


// BankAccount bankAccount  = new BankAccount(100);
// System.Console.WriteLine(bankAccount.GetBalance());

// bankAccount.Deposit(100);
// System.Console.WriteLine(bankAccount.GetBalance());


// bankAccount.Withdraw(-60);
// System.Console.WriteLine(bankAccount.GetBalance());
// =====================================================================================
// Abstraction

// using ConsoleApp1.src.Oop.Abstraction;
// EmailService emailService = new EmailService();
// emailService.sendEmail();

// =====================================================================================

// Inheritance


// using ConsoleApp1.src.Oop.Inheritance;

// var car = new Car();

// //Shared 
// car.Brand= "MS";
// car.Start();
// car.Stop();


// car.NumberOfDoors = 4;


// =====================================================================================

// polymorphism


// using ConsoleApp1.Polymorphism;

// List<Vehicle> vehicles = new List<Vehicle>();
// vehicles.Add(new Car{Brand = "MS",Model = "Wagon",Year = 2020,NumberOfDoors=4});
// vehicles.Add(new Motorcycle{Brand = "Honda",Model = "Sportster",Year = 2021});
// Console.WriteLine(vehicles);
// foreach(var vehicle in vehicles){
//     vehicle.Start();
// }


// foreach(var vehicle in vehicles){
//     if (vehicle is Car){
//         var car = (Car)vehicle;
//         car.Start();
//     }
//     else if(vehicle is Motorcycle){
// var Motorcycle = (Motorcycle)vehicle;
// Motorcycle.Start();
//     }
// }


// =====================================================================================

// Coupling


// using ConsoleApp1.Coupling;

// var order   = new Order(new EmailSender());
// var smsSender   = new Order(new SmsSender());
// order.PlaceOrder();
// smsSender.PlaceOrder();




// Abstract class with abstract properties
abstract class Shape
{
    public abstract double Width { get; set; }
    public abstract double Height { get; set; }
    public abstract double GetArea();
}

// Derived class overriding the abstract properties and method
class Rectangle : Shape
{
    public override double Width { get; set; }
    public override double Height { get; set; }

    public override double GetArea()
    {
        return Width * Height;
    }
}

// Usage
var rect = new Rectangle();
rect.Width = 5;
rect.Height = 10;
Console.WriteLine(rect.GetArea()); // Output: 50