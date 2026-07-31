using System; //System is a namespace that contains many classes used in C# 

namespace HelloWorld{ //namespace is a container for the C# classes and other namespaces
    class Program{ //container for data and methods that provides functionality to the program
        static void Main(string[] args){ //static is a keyword that means that the member/method 
                                         //belongs to the class itself rather than any object. We dont need to create an object of the Program class 
                                         //to call it.

            Console.WriteLine("Hello World"); //Console is a class of System namespace that has a method WriteLine
        }
    }
}