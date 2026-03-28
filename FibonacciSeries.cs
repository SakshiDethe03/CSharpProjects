using System;

class Program
{
    static void Main(string[] args)
    {
        int n, a = 0, b = 1, next;

        Console.Write("Enter number of terms: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Fibonacci Series:");

        for (int i = 1; i <= n; i++)
        {
            Console.Write(a + " ");

            next = a + b;
            a = b;
            b = next;
        }
    }
}