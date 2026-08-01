/*
1-> Collections:
Collections are classes in c# that are used to store and manage multiple data/objects
Categories: 
System.Collections(eg arraylist, hash class), System.Collections.Generic(eg stack,queue), System.Collections.Concurrent(for multithreading purposes)
When to use: Working with different data structures

2-> Generics:
Generics helps a class or method to be "type independent"
Generic Methods: A method that is type independent
Generic class: A class that can work with any type of parameters.
Why we use: for type safety and code reusability

Example(Generic method):
public bool AreEqual<T>(T value1, T value2) // This is a generic method, independent of the type
{ 
    if (value1==value2){
        return True;
    }
    else{
        return False;
    }
    Main()
    {
        bool isequal = AreEqual<int>(1,2);
        OR
        bool isequal = AreEqual<float>(1.2f,1.2f);
        OR
        bool isequal = AreEqual<string>("Ali","Ahmed");
    }
}

Example(Generic class):
class xyz<T>{
    public T value1;

    public Display(){
        Console.WriteLine(value1);
    }
}

3-> Delegates: A variable that Stores reference to a method 
OR
A delegates is a pointer to a method
Note: A delegate can point to more than one method of same return type and parameters(multicast delegates).
When to use: When we need to pass a method as a parameter, we use delegates.

4-> Events:
An event is used to notify other objects when something happens/ when a specific action occurs.

Difference between events and delegates:
Delegate is a variable that stores reference to a method and an event is a notification mechanism that
depends on delegates

5-> Lambda Expression:
A way of writing anonymous function in C#
(param)->expression
Example:
instead of:
public int square(int x){
    return x*x;
}
we can write this:
x-> ( x * x)

5-> LINQ (Language integrated query): Use to 
*/