using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> list = new List<int> { 1, 2, 3 };

        list.Add(4);

        foreach (int i in list)
            Console.WriteLine(i);
    }
}