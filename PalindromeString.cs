using System;

class Program
{
    static void Main()
    {
        string str = "madam";
        string rev = "";

        foreach(char c in str)
            rev = c + rev;

        Console.WriteLine(str == rev ? "Palindrome" : "Not Palindrome");
    }
}