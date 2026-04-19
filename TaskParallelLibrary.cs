using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task t = Task.Run(() => Console.WriteLine("Task Running"));
        t.Wait();
    }
}