using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt16(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt16(Console.ReadLine());

        int sum = a + b;
        Console.Write("The sum of Two numbers is: " + sum);
    }
}