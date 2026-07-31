/* Inheritance means that a class can acquire properties and behaviours of another class
1-> The class that inherits is called the derived or child class
2-> The class that is being inherited is called base or parent class*/

//Types:
// i) Single Inheritance (A derived class inherits only 1 base class )

class Vehicle
{
    public string brand = "Honda";
    public void Honk()
    {
        Console.WriteLine("Peep Peep!");
    }
}

class Car: Vehicle
{
    public string name = "Civic";
}
class Program
{
    static void Main(string[] args){
    Car c = new Car(); //making a derived class object
    Console.Write(c.brand); // car object accessing variable of its parent class
    Console.WriteLine(c.name);
    c.Honk(); // car object accessing method of its parent class
    }

}