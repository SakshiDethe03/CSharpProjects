using System;
using System.IO;

class Program
{
    static string file = "data.txt";

    static void Main()
    {
        File.WriteAllText(file, "Hello\n");
        File.AppendAllText(file, "World\n");

        string data = File.ReadAllText(file);
        Console.WriteLine(data);
    }
}