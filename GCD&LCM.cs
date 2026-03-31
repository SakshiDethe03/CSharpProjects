using System;

class Program
{
    static void Main(string[] args)
    {
        int a, b, gcd, lcm;

        Console.Write("Enter first number: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        b = Convert.ToInt32(Console.ReadLine());

        int x = a, y = b;

        // Find GCD using Euclidean Algorithm
        while (y != 0)
        {
            int temp = y;
            y = x % y;
            x = temp;
        }

        gcd = x;

        // Find LCM
        lcm = (a * b) / gcd;

        Console.WriteLine("GCD = " + gcd);
        Console.WriteLine("LCM = " + lcm);
    }
}