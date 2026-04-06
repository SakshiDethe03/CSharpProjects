using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime now = DateTime.Now;

        Console.WriteLine("Current Date: " + now.ToShortDateString());
        Console.WriteLine("Current Time: " + now.ToShortTimeString());
        Console.WriteLine("Full: " + now);
    }
}