using System;
using System.Collections.Generic;

class Account
{
    public string AccountNumber { get; set; }
    public string Holder { get; set; }
    public decimal Balance { get; set; }
    public List<string> Transactions { get; set; }
}

class Program
{
    static List<Account> accounts = new List<Account>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== ATM Machine ===");
            Console.WriteLine("1.Create Account 2.Deposit 3.Withdraw 4.Mini Statement 5.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    string accNo = "ACC" + (accounts.Count + 1);
                    accounts.Add(new Account { AccountNumber = accNo, Holder = name, Balance = 0, Transactions = new List<string>() });
                    Console.WriteLine($"Account: {accNo}");
                    break;

                case 2:
                    Console.Write("Account: ");
                    accNo = Console.ReadLine();
                    Console.Write("Amount: ");
                    decimal amt = decimal.Parse(Console.ReadLine());
                    var acc = accounts.Find(a => a.AccountNumber == accNo);
                    if (acc != null)
                    {
                        acc.Balance += amt;
                        acc.Transactions.Add($"Deposit: +${amt}");
                        Console.WriteLine($"Balance: ${acc.Balance}");
                    }
                    break;

                case 3:
                    Console.Write("Account: ");
                    accNo = Console.ReadLine();
                    Console.Write("Amount: ");
                    amt = decimal.Parse(Console.ReadLine());
                    acc = accounts.Find(a => a.AccountNumber == accNo);
                    if (acc != null && acc.Balance >= amt)
                    {
                        acc.Balance -= amt;
                        acc.Transactions.Add($"Withdrawal: -${amt}");
                        Console.WriteLine($"Balance: ${acc.Balance}");
                    }
                    break;

                case 4:
                    Console.Write("Account: ");
                    accNo = Console.ReadLine();
                    acc = accounts.Find(a => a.AccountNumber == accNo);
                    if (acc != null)
                    {
                        foreach (var t in acc.Transactions)
                            Console.WriteLine(t);
                    }
                    break;

                case 5:
                    return;
            }
        }
    }
}