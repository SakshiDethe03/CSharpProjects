using System;

class Program
{
    static void Main()
    {
        string str = "hello";
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);

        Console.WriteLine(new string(arr));
    }
}