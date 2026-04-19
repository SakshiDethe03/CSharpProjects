using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Stopwatch sw = new Stopwatch();

        sw.Start();
        for (int i = 0; i < 1000000; i++) { }
        sw.Stop();

        Console.WriteLine("Time: " + sw.ElapsedMilliseconds);
    }
}