using System;

class Program
{
    static void Main()
    {
        int[][] arr = new int[2][];

        arr[0] = new int[] { 1, 2 };
        arr[1] = new int[] { 3, 4, 5 };

        foreach (var row in arr)
        {
            foreach (var val in row)
                Console.Write(val + " ");
            Console.WriteLine();
        }
    }
}