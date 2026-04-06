using System;

class Program
{
    static void Main(string[] args)
    {
        int days, years, months;

        Console.Write("Enter number of days: ");
        days = Convert.ToInt32(Console.ReadLine());

        years = days / 365;
        days = days % 365;

        months = days / 30;
        days = days % 30;

        Console.WriteLine("Years: " + years);
        Console.WriteLine("Months: " + months);
        Console.WriteLine("Days: " + days);
    }
}