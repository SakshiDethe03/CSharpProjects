using System;
using System.Collections.Generic;

class Expense
{
    public string Description { get; set; }
    public decimal Amount { get; set; }
    public string Category { get; set; }
    public DateTime Date { get; set; }
}

class Program
{
    static List<Expense> expenses = new List<Expense>();
    static decimal balance = 5000m;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine($"\n=== Budget Tracker | Balance: ${balance} ===");
            Console.WriteLine("1.Add Expense 2.View All 3.By Category 4.Total 5.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Description: ");
                    string desc = Console.ReadLine();
                    Console.Write("Amount: ");
                    decimal amt = decimal.Parse(Console.ReadLine());
                    Console.Write("Category (Food/Rent/Transport/Other): ");
                    string cat = Console.ReadLine();
                    expenses.Add(new Expense { Description = desc, Amount = amt, Category = cat, Date = DateTime.Now });
                    balance -= amt;
                    Console.WriteLine("Expense added!");
                    break;

                case 2:
                    foreach (var e in expenses)
                        Console.WriteLine($"{e.Date:yyyy-MM-dd} | {e.Category} | {e.Description} | ${e.Amount}");
                    break;

                case 3:
                    Console.Write("Category: ");
                    cat = Console.ReadLine();
                    foreach (var e in expenses.FindAll(x => x.Category == cat))
                        Console.WriteLine($"{e.Description} | ${e.Amount}");
                    break;

                case 4:
                    decimal total = 0;
                    foreach (var e in expenses) total += e.Amount;
                    Console.WriteLine($"Total Expenses: ${total}");
                    Console.WriteLine($"Remaining Balance: ${balance}");
                    break;

                case 5:
                    return;
            }
        }
    }
}