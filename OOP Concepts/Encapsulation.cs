/* Encapsulation means to bind the data members(variables) and methods(functions) together in a class 
                                        OR
Hiding the data members and give only a controlled access to them
1-> It restricts the direct access from outside the class
2-> Class data members(variables) are set private so they can't be accessed from anywhere outside the class 
and to access them(view and update values safely) we use getters and setters*/

class BankAccount
{
    private int balance;
    public void Deposit(int amount)
    {
        if(amount>0){
        balance += amount;
        Console.WriteLine("Amount Deposited Successfully");}
    }
    public int Getbalance()
    {
        return balance;
    }
}
class Program
{
    static void Main(string[] args)
    {
        BankAccount b1 = new BankAccount();
        //b1.balance; //Error: BankAccount.balance is not accessible due to its protection level
        b1.Deposit(1000);
        Console.WriteLine(b1.Getbalance());
    }
}