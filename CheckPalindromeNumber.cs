using System;

class Program
{
    static void Main(string[] args)
    {
        int num, original, reverse = 0, remainder;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        original = num;

        while (num != 0)
        {
            remainder = num % 10;
            reverse = reverse * 10 + remainder;
            num = num / 10;
        }

        if (original == reverse)
        {
            Console.WriteLine("Number is Palindrome");
        }
        else
        {
            Console.WriteLine("Number is Not Palindrome");
        }
    }
}