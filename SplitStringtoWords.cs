using System;

class Program
{
    static void Main()
    {
        string str = "Hello C Sharp World";
        string[] words = str.Split(' ');

        foreach (string w in words)
            Console.WriteLine(w);
    }
}