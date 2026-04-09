using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();

        string str = "Hello World";

        Console.Write("Before replacement: " + str + "\n");

        string result = str.Replace("World", name);

        Console.Write("After replacement: " + result + "\n");
    }
}