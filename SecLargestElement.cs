using System;

class Program
{
    static void Main()
    {
        int[] arr = { 10, 5, 20, 8 };

        Array.Sort(arr);
        Console.WriteLine("Second Largest = " + arr[arr.Length - 2]);
    }
}