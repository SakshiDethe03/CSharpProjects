using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string str = "sakshi";
        Dictionary<char,int> freq = new Dictionary<char,int>();

        foreach(char c in str)
        {
            if(freq.ContainsKey(c))
                freq[c]++;
            else
                freq[c] = 1;
        }

        foreach(var item in freq)
            Console.WriteLine(item.Key + " : " + item.Value);
    }
}