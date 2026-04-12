using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string pass = "000";

        bool strong =
            pass.Length >= 8 &&
            Regex.IsMatch(pass, "[A-Z]") &&
            Regex.IsMatch(pass, "[a-z]") &&
            Regex.IsMatch(pass, "[0-9]") &&
            Regex.IsMatch(pass, "[^a-zA-Z0-9]");

        Console.WriteLine(strong ? "Strong" : "Weak");
    }
}