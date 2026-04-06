using System;

class Program
{
    static void Main(string[] args)
    {
        var x = 10;       // compile-time type
        dynamic y = 20;   // runtime type

        y = "Hello"; // allowed

        Console.WriteLine("var x: " + x);
        Console.WriteLine("dynamic y: " + y);
    }
}