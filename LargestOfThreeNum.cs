using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter First Number: ");
        int a = Convert.ToInt16(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        int b = Convert.ToInt16(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        int c = Convert.ToInt16(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.WriteLine("Maximum number is " + a);
        } 
        else if (b > a && b > c)
        {
            Console.WriteLine("Maximum number is " + b);
        }
        else
        {
            Console.WriteLine("Maximun number is " + c);
        }
    }
}