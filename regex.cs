using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "abc123";

        Console.WriteLine(Regex.IsMatch(text, "[a-z]+"));
    }
}