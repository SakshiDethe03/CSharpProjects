using System;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter your age: ");
        int age = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter your address: ");
        string adrs = Console.ReadLine();

        Console.WriteLine("\n-----User Details-----\n");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("\nAge: " + age);
        Console.WriteLine("\nAddress: " + adrs);
    }
}