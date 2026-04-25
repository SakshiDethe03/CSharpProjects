using System;
using System.Collections.Generic;

class Loan
{
    public string Borrower { get; set; }
    public decimal Amount { get; set; }
    public decimal InterestRate { get; set; }
    public int Months { get; set; }
    public decimal MonthlyPayment { get; set; }
}

class Program
{
    static List<Loan> loans = new List<Loan>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Loan Calculator ===");
            Console.WriteLine("1.Calculate Loan 2.View Loans 3.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Borrower Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Loan Amount: ");
                    decimal amount = decimal.Parse(Console.ReadLine());
                    Console.Write("Interest Rate (%): ");
                    decimal rate = decimal.Parse(Console.ReadLine());
                    Console.Write("Months: ");
                    int months = int.Parse(Console.ReadLine());

                    decimal monthlyRate = rate / 100 / 12;
                    decimal payment = amount * monthlyRate * (decimal)Math.Pow((double)(1 + monthlyRate), months) / ((decimal)Math.Pow((double)(1 + monthlyRate), months) - 1);

                    loans.Add(new Loan { Borrower = name, Amount = amount, InterestRate = rate, Months = months, MonthlyPayment = payment });
                    Console.WriteLine($"Monthly Payment: ${payment:F2}");
                    break;

                case 2:
                    foreach (var l in loans)
                        Console.WriteLine($"{l.Borrower} | ${l.Amount} | {l.Months} months @ {l.InterestRate}% | ${l.MonthlyPayment:F2}/mo");
                    break;

                case 3:
                    return;
            }
        }
    }
}