using System;
using System.Collections.Generic;

class Item
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
}

class Program
{
    static List<Item> cart = new List<Item>();
    static List<Item> catalog = new List<Item>
    {
        new Item { Name = "Laptop", Price = 50000, Stock = 10 },
        new Item { Name = "Mouse", Price = 500, Stock = 50 },
        new Item { Name = "Keyboard", Price = 1000, Stock = 30 },
        new Item { Name = "Monitor", Price = 15000, Stock = 15 }
    };

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== E-Commerce ===");
            Console.WriteLine("1.Browse 2.Add to Cart 3.Cart 4.Checkout 5.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    foreach (var i in catalog)
                        Console.WriteLine($"{i.Name} - ${i.Price} (Stock: {i.Stock})");
                    break;

                case 2:
                    Console.Write("Item: ");
                    string name = Console.ReadLine();
                    var item = catalog.Find(i => i.Name == name);
                    if (item != null && item.Stock > 0)
                    {
                        cart.Add(item);
                        item.Stock--;
                        Console.WriteLine("Added!");
                    }
                    break;

                case 3:
                    decimal total = 0;
                    foreach (var i in cart)
                    {
                        Console.WriteLine($"{i.Name} - ${i.Price}");
                        total += i.Price;
                    }
                    Console.WriteLine($"Total: ${total}");
                    break;

                case 4:
                    total = 0;
                    foreach (var i in cart) total += i.Price;
                    Console.WriteLine($"Paid ${total}! Order placed.");
                    cart.Clear();
                    break;

                case 5:
                    return;
            }
        }
    }
}