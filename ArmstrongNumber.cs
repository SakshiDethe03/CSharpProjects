using System;

class Program
{
    static void Main(string[] args)
    {
        int num, original, remainder, result = 0, n = 0;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        original = num;

        // Count number of digits
        while (original != 0)
        {
            original /= 10;
            n++;
        }

        original = num;

        // Calculate sum of powers
        while (original != 0)
        {
            remainder = original % 10;
            result += (int)Math.Pow(remainder, n);
            original /= 10;
        }

        // Check Armstrong
        if (result == num)
        {
            Console.WriteLine("Number is an Armstrong number");
        }
        else
        {
            Console.WriteLine("Number is not an Armstrong number");
        }
    }
}