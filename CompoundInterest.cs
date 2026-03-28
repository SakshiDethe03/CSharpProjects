using System;

class Program
{
    static void Main(string[] args)
    {
        double P, R, T, CI, Amount;

        Console.Write("Enter Principal Amount: ");
        P = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of Interest: ");
        R = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time (in years): ");
        T = Convert.ToDouble(Console.ReadLine());

        Amount = P * Math.Pow((1 + R / 100), T);
        CI = Amount - P;

        Console.WriteLine("Compound Interest = " + CI);
    }
}