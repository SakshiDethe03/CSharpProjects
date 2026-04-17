using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> dict = new Dictionary<int, string>();

        dict.Add(1, "One");
        dict.Add(2, "Two");

        foreach (var item in dict)
            Console.WriteLine(item.Key + " : " + item.Value);
    }
}