using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] names = { "Ram", "Ravi", "Sita", "Sam" };

        var groups = names.GroupBy(x => x[0]);

        foreach (var g in groups)
        {
            Console.WriteLine("Group: " + g.Key);
            foreach (var name in g)
                Console.WriteLine(name);
        }
    }
}