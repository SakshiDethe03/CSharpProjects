using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 10, b = 5;

        // Arithmetic
        Console.WriteLine("Addition: " + (a + b));
        Console.WriteLine("Subtraction: " + (a - b));

        // Relational
        Console.WriteLine("a > b: " + (a > b));

        // Logical
        Console.WriteLine("(a > b && b > 0): " + (a > b && b > 0));

        // Assignment
        a += b;
        Console.WriteLine("a after += : " + a);
    }
}