using System;

class Program
{
    static void Main(string[] args)
    {
        int count = 0, n;
        string str;

        Console.Write("Enter a string: ");
        str = Console.ReadLine();

        n = str.Length;

        for(int i = 0; i < n; i++)
        {
           count++; 
        }

        Console.WriteLine("Count: " + count);
    }
}