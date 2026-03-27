using System;

class Program
{
    static void Main(string[] args)
    {
        int n, sum = 0, num;

        Console.Write("Enter count of the numbers: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the numbers: ");

        for(int i = 0; i < n; i++)
        {
            num = Convert.ToInt32(Console.ReadLine());
            sum += num;
        }

        Console.WriteLine("Sum of digits = " + sum);
    }
}