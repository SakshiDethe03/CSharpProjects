using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 5, 2, 9, 1, 7 };

        int max = arr[0];
        int min = arr[0];

        foreach (int i in arr)
        {
            if (i > max)
                max = i;

            if (i < min)
                min = i;
        }

        Console.WriteLine("Largest = " + max);
        Console.WriteLine("Smallest = " + min);
    }
}