using System;

class Account
{
    public double Balance { get; set; }

    public void Deposit(double amt) => Balance += amt;

    public void Withdraw(double amt)
    {
        if (amt <= Balance) Balance -= amt;
        else Console.WriteLine("Insufficient Balance");
    }
}

class Program
{
    static void Main()
    {
        Account acc = new Account();

        acc.Deposit(1000);
        acc.Withdraw(300);

        Console.WriteLine("Balance: " + acc.Balance);
    }
}