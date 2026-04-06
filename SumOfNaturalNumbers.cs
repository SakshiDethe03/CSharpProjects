using System;

class Program
{
    static void Main(string[] args)
    {
        int n, sum = 0;

        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        Console.WriteLine("Sum of natural numbers = " + sum);
    }
}