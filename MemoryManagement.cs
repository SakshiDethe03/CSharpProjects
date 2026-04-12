using System;

class Program
{
    static void Main()
    {
        object obj = new object();

        obj = null; // eligible for garbage collection

        GC.Collect(); // force GC 
        Console.WriteLine("Memory cleaned");
    }
}