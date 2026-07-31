/*Polymorphism is a property of a method or interface to exist in more than one forms
 OR
 A method can have different behaviours in different situations
Types:
1-> Compile time polymorphism (Acheived by function / operator overloading ). Uses early binding
2-> Run time polymorphism (Acheived by function overriding). Uses late binding
*/

//1) Compile time (function overloading(a function with same name but different parameters)):
/*class Claculator
{
    public int Sum(int a , int b)
    {
        return a+b;
    }
    public float Sum(float a, float b)
    {
        return a+b;
    }
    public int Sum(int a, int b, int c)
    {
        return a+b+c;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Claculator c = new Claculator();
        Console.WriteLine(c.Sum(2,3));
        Console.WriteLine(c.Sum(2.2f,3.1f));
        Console.WriteLine(c.Sum(2,3,5));
    }
}*/

//2) Operator overloading (An operator can be used for other tasks)
//3)Runtime(Acheived by operator overriding(uses virtual keyword))
