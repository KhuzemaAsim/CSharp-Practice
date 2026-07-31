//string name = Console.ReadLine();
//Console.WriteLine(name);

//In some cases, ReadLine() can cause issues because it returns a string whatever is written on the keyboard
//For example

//int number = Console.ReadLine(); //Error: Cannot implicitly convert string to int
//Solution:
//int number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(number);

//bool isyes = Console.ReadLine(); //Error: Cannot implicitly convert string to bool
//Solution:
bool isyes = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine(isyes);
