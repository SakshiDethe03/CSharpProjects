using System;

class Program
{
    static void Print(int[] arr)
    {
        foreach (int i in arr)
            Console.Write(i + " ");
    }

    static void Main()
    {
        int[] arr = { 1, 2, 3 };
        Print(arr);
    }
}