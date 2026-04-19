using System;
using System.Threading;

class Program
{
    static void Work()
    {
        Console.WriteLine("Thread Running");
    }

    static void Main()
    {
        Thread t = new Thread(Work);
        t.Start();
    }
}