using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> set = new HashSet<int> { 1, 2, 2, 3 };

        foreach (int i in set)
            Console.WriteLine(i);
    }
}