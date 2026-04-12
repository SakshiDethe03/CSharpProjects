using System;

class Program
{
    static void Main()
    {
        string a = "listen";
        string b = "silent";

        char[] x = a.ToCharArray();
        char[] y = b.ToCharArray();

        Array.Sort(x);
        Array.Sort(y);

        Console.WriteLine(new string(x) == new string(y));
    }
}