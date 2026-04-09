using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 10, 20, 30, 40 };
        int sum = 0;

        foreach (int i in arr)
        {
            sum += i;
        }

        double avg = (double)sum / arr.Length;

        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Average = " + avg);
    }
}