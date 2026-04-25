using System;
using System.Collections.Generic;

class Account
{
    public string AccountNumber { get; set; }
    public string Holder { get; set; }
    public decimal Balance { get; set; }
    public string Type { get; set; }
}

class Program
{
    static List<Account> accounts = new List<Account>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Bank Account Manager ===");
            Console.WriteLine("1.Create Account 2.Deposit 3.Withdraw 4.Transfer 5.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Type (Savings/Current): ");
                    string type = Console.ReadLine();
                    string accNo = "SB" + (accounts.Count + 1);
                    accounts.Add(new Account { AccountNumber = accNo, Holder = name, Type = type, Balance = 0 });
                    Console.WriteLine($"Account: {accNo}");
                    break;

                case 2:
                    Console.Write("Account: ");
                    string acc = Console.ReadLine();
                    Console.Write("Amount: ");
                    decimal amt = decimal.Parse(Console.ReadLine());
                    var a = accounts.Find(x => x.AccountNumber == acc);
                    if (a != null) { a.Balance += amt; Console.WriteLine($"Balance: ${a.Balance}"); }
                    break;

                case 3:
                    Console.Write("Account: ");
                    acc = Console.ReadLine();
                    Console.Write("Amount: ");
                    amt = decimal.Parse(Console.ReadLine());
                    a = accounts.Find(x => x.AccountNumber == acc);
                    if (a != null && a.Balance >= amt) { a.Balance -= amt; Console.WriteLine($"Balance: ${a.Balance}"); }
                    break;

                case 4:
                    Console.Write("From: ");
                    string from = Console.ReadLine();
                    Console.Write("To: ");
                    string to = Console.ReadLine();
                    Console.Write("Amount: ");
                    amt = decimal.Parse(Console.ReadLine());
                    var fromAcc = accounts.Find(x => x.AccountNumber == from);
                    var toAcc = accounts.Find(x => x.AccountNumber == to);
                    if (fromAcc != null && toAcc != null && fromAcc.Balance >= amt)
                    {
                        fromAcc.Balance -= amt;
                        toAcc.Balance += amt;
                        Console.WriteLine("Transferred!");
                    }
                    break;

                case 5:
                    return;
            }
        }
    }
}