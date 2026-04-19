using System;
using System.Collections.Generic;

class Item
{
    public string Name;
    public int Qty;
}

class Program
{
    static void Main()
    {
        List<Item> items = new List<Item>
        {
            new Item { Name = "Pen", Qty = 10 }
        };

        foreach (var i in items)
            Console.WriteLine($"{i.Name} - {i.Qty}");
    }
}