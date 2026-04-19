using System;
using System.IO;

class Program
{
    static void Main()
    {
        File.WriteAllText("test.txt", "Hello File");
        string data = File.ReadAllText("test.txt");

        Console.WriteLine(data);
    }
}