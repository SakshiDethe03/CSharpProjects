using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
}

class Program
{
    static List<Product> products = new List<Product>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Supermarket Inventory ===");
            Console.WriteLine("1.Add Product 2.View All 3.Low Stock 4.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Category: ");
                    string cat = Console.ReadLine();
                    Console.Write("Price: ");
                    decimal price = decimal.Parse(Console.ReadLine());
                    Console.Write("Stock: ");
                    int stock = int.Parse(Console.ReadLine());
                    products.Add(new Product { Name = name, Category = cat, Price = price, Stock = stock });
                    Console.WriteLine("Added!");
                    break;

                case 2:
                    foreach (var p in products)
                        Console.WriteLine($"{p.Name} | {p.Category} | ${p.Price} | Stock: {p.Stock}");
                    break;

                case 3:
                    Console.Write("Threshold: ");
                    int threshold = int.Parse(Console.ReadLine());
                    foreach (var p in products.FindAll(x => x.Stock < threshold))
                        Console.WriteLine($"{p.Name}: {p.Stock} left");
                    break;

                case 4:
                    return;
            }
        }
    }
}