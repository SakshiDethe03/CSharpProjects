using System;

class Program
{
    static void Main()
    {
        ReadOnlySpan<int> span = new int[] {1,2,3};
        Console.WriteLine(span[0]);
    }
}