using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 5, 2, 9, 1, 7 };

        Array.Sort(arr);

        Console.WriteLine("Sorted array:");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
    }
}