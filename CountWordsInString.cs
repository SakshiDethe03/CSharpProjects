using System;

class Program
{
    static void Main()
    {
        string str = "Hello world from Sakshi!";
        string[] words = str.Split(' ');

        Console.WriteLine("Word count = " + words.Length);
    }
}