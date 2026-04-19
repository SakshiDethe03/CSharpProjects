using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        await Task.Delay(1000);
        Console.WriteLine("Async Done");
    }
}