using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder("Hello");

        sb.Append(" World");
        sb.Replace("World", "CSharp");

        Console.WriteLine(sb.ToString());
    }
}