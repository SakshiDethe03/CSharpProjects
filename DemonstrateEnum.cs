using System;

enum Days { Monday, Tuesday, Wednesday }

class Program
{
    static void Main(string[] args)
    {
        Days d = Days.Monday;
        Console.WriteLine("Day: " + d);
    }
}