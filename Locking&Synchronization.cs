using System;
using System.Threading;

class Program
{
    static object lockObj = new object();

    static void Main()
    {
        lock (lockObj)
        {
            Console.WriteLine("Critical Section");
        }
    }
}