/* Interface is another method to acheive abstraction
It only has abstract methods 
Interview Question: Difference between Interface and Abstract class?
Answer: Interface is another way to acheive abstraction apart from Abstract class, but the major difference 
between the two is that Abstract class can have implemented method, but interface only defines what a class
must implement. Another difference is that interface dont contains feilds, abstract class can have feild values.
By default interface methods are abstract and public
Derived class must implement all methods of the interface*/

interface Vehicle
{
    void Start();
    void Honk();
    void GearShift();
}

class Car : Vehicle
{
    public void Start()
    {
        Console.WriteLine("Car is starting");
    }
    public void Honk()
    {
        Console.WriteLine("Peep Peep!");
    }
    public void GearShift()
    {
        Console.WriteLine("Car is shifting gear");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Car c = new Car();
        c.Start();
        c.Honk();
        c.GearShift();

    }
}