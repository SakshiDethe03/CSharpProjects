using System;

class Program
{
    static void Main(string[] args)
    {
        int start, end;

        Console.Write("Enter start number: ");
        start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter end number: ");
        end = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Prime numbers in range:");

        for (int i = start; i <= end; i++)
        {
            int count = 0;

            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    count++;
                }
            }

            if (count == 2)
            {
                Console.Write(i + " ");
            }
        }
    }
}