using System;
using System.Collections.Generic;

class Account
{
    public string AccountNumber { get; set; }
    public string HolderName { get; set; }
    public decimal Balance { get; set; }
}

class Program
{
    static List<Account> accounts = new List<Account>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Banking System ===");
            Console.WriteLine("1.Create Account 2.Deposit 3.Withdraw 4.Transfer 5.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    string accNo = "ACC" + (accounts.Count + 1);
                    accounts.Add(new Account { AccountNumber = accNo, HolderName = name, Balance = 0 });
                    Console.WriteLine($"Account created! Acc#: {accNo}");
                    break;

                case 2:
                    Console.Write("Account #: ");
                    accNo = Console.ReadLine();
                    var acc = accounts.Find(a => a.AccountNumber == accNo);
                    if (acc != null)
                    {
                        Console.Write("Amount: ");
                        decimal amt = decimal.Parse(Console.ReadLine());
                        acc.Balance += amt;
                        Console.WriteLine($"New Balance: ${acc.Balance}");
                    }
                    break;

                case 3:
                    Console.Write("Account #: ");
                    accNo = Console.ReadLine();
                    acc = accounts.Find(a => a.AccountNumber == accNo);
                    if (acc != null)
                    {
                        Console.Write("Amount: ");
                        decimal amt = decimal.Parse(Console.ReadLine());
                        if (amt <= acc.Balance)
                        {
                            acc.Balance -= amt;
                            Console.WriteLine($"New Balance: ${acc.Balance}");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient funds!");
                        }
                    }
                    break;

                case 4:
                    Console.Write("From Account #: ");
                    string from = Console.ReadLine();
                    Console.Write("To Account #: ");
                    string to = Console.ReadLine();
                    Console.Write("Amount: ");
                    decimal amount = decimal.Parse(Console.ReadLine());
                    var fromAcc = accounts.Find(a => a.AccountNumber == from);
                    var toAcc = accounts.Find(a => a.AccountNumber == to);
                    if (fromAcc != null && toAcc != null && fromAcc.Balance >= amount)
                    {
                        fromAcc.Balance -= amount;
                        toAcc.Balance += amount;
                        Console.WriteLine("Transfer successful!");
                    }
                    else
                    {
                        Console.WriteLine("Transfer failed!");
                    }
                    break;

                case 5:
                    return;
            }
        }
    }
}