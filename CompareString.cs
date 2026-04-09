using System;

class Program
{
    static void Main()
    {
        string s1 = "hello";
        string s2 = "HELLO";

        Console.WriteLine(s1.Equals(s2)); // case-sensitive
        Console.WriteLine(s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
    }
}