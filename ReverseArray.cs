using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        Array.Reverse(arr);

        Console.WriteLine("Reversed array:");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
    }
}