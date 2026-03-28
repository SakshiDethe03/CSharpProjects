using System;

class Program
{
    static void Main(string[] args)
    {
        double P, R, T, SI;

        Console.Write("Enter Principal Amount: ");
        P = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of Interest: ");
        R = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time (in years): ");
        T = Convert.ToDouble(Console.ReadLine());

        SI = (P * R * T) / 100;

        Console.WriteLine("Simple Interest = " + SI);
    }
}