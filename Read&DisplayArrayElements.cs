using System;

class Program
{
    static void Main(string[] args)
    {
        int n;

        Console.Write("Enter size of array: ");
        n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Array elements are:");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
    }
}