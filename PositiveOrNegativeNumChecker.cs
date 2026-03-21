using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt16(Console.ReadLine());

        if(num < 0)
        {
            Console.WriteLine(num + " is Negative");
        }
        else if (num > 0)
        {
            Console.WriteLine(num + " is Positive");
        }
        else
        {
            Console.WriteLine(num + " is Zero");
        }
    }    
}