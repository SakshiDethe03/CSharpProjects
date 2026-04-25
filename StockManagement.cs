using System;
using System.Collections.Generic;

class Item
{
    public string Name { get; set; }
    public int Quantity { get; set; }
}

class Program
{
    static List<Item> inventory = new List<Item>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Stock Management ===");
            Console.WriteLine("1.Add Item 2.View Stock 3.Update Qty 4.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Item Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Quantity: ");
                    int qty = int.Parse(Console.ReadLine());
                    inventory.Add(new Item { Name = name, Quantity = qty });
                    Console.WriteLine("Item added!");
                    break;

                case 2:
                    foreach (var i in inventory)
                        Console.WriteLine($"{i.Name}: {i.Quantity} units");
                    break;

                case 3:
                    Console.Write("Item Name: ");
                    name = Console.ReadLine();
                    var item = inventory.Find(i => i.Name == name);
                    if (item != null)
                    {
                        Console.Write("New Quantity: ");
                        item.Quantity = int.Parse(Console.ReadLine());
                        Console.WriteLine("Updated!");
                    }
                    break;

                case 4:
                    return;
            }
        }
    }
}