using System;
using System.Globalization;

class Program
{
    static void Main(String[] args)
    {
        int i, num;

        Console.Write("Enter a number: ");
        num = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Multiplication Table of "+num);

        for(i = 1; i <= 10; i++)
        {
            Console.WriteLine(num + " X " + i + " = " +(num * i));
        }
    }
}