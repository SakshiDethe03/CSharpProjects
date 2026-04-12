using System;

class Program
{
    static void Main()
    {
        int[] arr = {1,2,4,5};
        int n = 5;

        int sum = n * (n + 1) / 2;
        int arrSum = 0;

        foreach(int i in arr)
            arrSum += i;

        Console.WriteLine("Missing = " + (sum - arrSum));
    }
}