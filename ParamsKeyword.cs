using System;

class Program
{
    static int Sum(params int[] nums)
    {
        int sum = 0;
        foreach (int i in nums)
            sum += i;
        return sum;
    }

    static void Main()
    {
        Console.WriteLine(Sum(1, 2, 3, 4));
    }
}