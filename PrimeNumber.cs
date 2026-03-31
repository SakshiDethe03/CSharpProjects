using System;

class Program
{
    static void Main(string[] args)
    {
        int num, count = 0;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                count++;
            }
        }

        if (count == 2)
        {
            Console.WriteLine(num + " is a Prime Number");
        }
        else
        {
            Console.WriteLine(num + " is Not a Prime Number");
        }
    }
}