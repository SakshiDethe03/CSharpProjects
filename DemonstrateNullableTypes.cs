using System;

class Program
{
    static void Main(string[] args)
    {
        int? num = null;

        if (num.HasValue)
            Console.WriteLine(num.Value);
        else
            Console.WriteLine("Value is null");
    }
}