/*iii) Heirarchical Inheritence (Multiple classes can inherit from 1 base class)*/

class Vehicle
{
    public void Start()
    {
        Console.WriteLine("Vehicle is Starting");
    }
}
class Car: Vehicle
{
    
}
class Bike : Vehicle
{
    
}
class Program
{
    static void Main(string[] args)
    {
        Car c = new Car();
        Bike b = new Bike();
        c.Start();
        b.Start();
    }
}