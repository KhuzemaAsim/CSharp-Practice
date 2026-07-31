//Struct is a value type that can store values of different data types.
//Difference between struct and class?
/*i) Struct is value type(stores actual value directly), class is reference type(stores address of the object)
ii) A struct object can be copied into another struct by using =
iii)Struct dont support inheritence, class support inheritence*/

struct Vehicle
{
    public string name;
    public string color;
}
struct Car
{
    
}
class Program
{
    static void Main(string[] args)
    {
        Vehicle v1;
        Vehicle v2;
        v1.name="Honda";
        v1.color="red";
        v2=v1; 
        Console.WriteLine(v1.name);
        Console.WriteLine(v2.name);
    }
}