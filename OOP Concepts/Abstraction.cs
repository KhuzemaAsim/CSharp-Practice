/* Abstraction means to hide the internal implementation details and show only essential info to the user
Can be acheived by using abstract classes or interfaces in C# 

1-> Abstract Class = The class jiska object create nahi kar saktay (it is accessible only if it is inherited
from another class ). Its like a blueprint with methods signatures maybe.
2-> Abstract Method = A method without body. The body is provided by the derived class*/

abstract class Vehicle
{
    public abstract void Start(); // an abstract method. Its body will be defined by the derived class depending on its own implementation
    public void Display()
    {
        Console.WriteLine("This is a Vehicle");
    }
}
class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Car is starting");
    }
}
class Bike: Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Bike is starting");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Car c = new Car();
        Bike b = new Bike();

        c.Start();
        b.Start();
        c.Display();
    }
}
