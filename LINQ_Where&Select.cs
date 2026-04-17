using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] nums = { 1, 2, 3, 4, 5 };

        var result = nums.Where(x => x % 2 == 0)
                         .Select(x => x * 10);

        foreach (var i in result)
            Console.WriteLine(i);
    }
}