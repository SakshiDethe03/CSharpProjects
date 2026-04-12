using System;

class Program
{
    static void Print(int a)
    {
        Console.WriteLine(a);
    }

    static void Print(string a)
    {
        Console.WriteLine(a);
    }

    static void Main()
    {
        Print(10);
        Print("Hello");
    }
}