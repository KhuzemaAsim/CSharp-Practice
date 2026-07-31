// ii) Multilevel Inheritance (A class inherits from a class which inherits from another class) 
//Vehicle->Four Wheeler->Car

class Vehicle
{
    public void Honk()
    {
        Console.WriteLine("Peep Peep!");
    }
}
class FourWheeler : Vehicle
{
    public string brand = "Suzuki";
    public void Display()
    {
        Console.WriteLine("This vehicle is FourWheeler");
    }
}
class Car : FourWheeler
{
    public string name = "Bolan";
    public void Info()
    {
        Console.WriteLine("This FourWheeler Vehicle is a car");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Car c = new Car();
        c.Honk();
        c.Display();
        c.brand = "Honda";
        Console.WriteLine(c.brand);
    }
}
