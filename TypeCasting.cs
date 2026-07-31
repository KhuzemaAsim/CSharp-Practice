/*
Typecasting means that when we assigns a value of a data type to another datatype
There are 2 types:
1-> Implicit Typecasting: (Automatically done). Converting smaller data type to larger. eg char->int->long
2-> Explicit Typecasting: (Manually done). Converting larger data type to smaller. eg double->float
*/

//Implicit
int number=5;
double mynumber = number; //int is converted to double
Console.WriteLine(number);
Console.WriteLine(mynumber);

//Explicit
double number1=9.9;
int mynumber1= (int) number1; //double is converted into int
Console.WriteLine(number1);
Console.WriteLine(mynumber1); 

//Type Conversion Built-in Methods (Use Convert class to use the methods)
int myint=10;
Console.WriteLine(Convert.ToString(myint));
Console.WriteLine(Convert.ToDouble(myint));
