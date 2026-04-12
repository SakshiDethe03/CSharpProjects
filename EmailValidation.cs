using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string email = "test@gmail.com";

        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        Console.WriteLine(Regex.IsMatch(email, pattern));
    }
}