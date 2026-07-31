//Struct is a value type that can store values of different data types.
//Difference between struct and class?
/*i) Struct stores value type, class stores reference type
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