using System;
using System.Collections.Generic;

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
}

class Program
{
    static List<Product> products = new List<Product>();
    static int nextId = 1;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Inventory System ===");
            Console.WriteLine("1.Add Product 2.View All 3.Update Stock 4.Sell 5.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    decimal price = decimal.Parse(Console.ReadLine());
                    Console.Write("Stock: ");
                    int stock = int.Parse(Console.ReadLine());
                    products.Add(new Product { Id = nextId++, Name = name, Price = price, Stock = stock });
                    Console.WriteLine("Product added!");
                    break;

                case 2:
                    foreach (var p in products)
                        Console.WriteLine($"{p.Id}. {p.Name} - ${p.Price} (Stock: {p.Stock})");
                    break;

                case 3:
                    Console.Write("Product ID: ");
                    int id = int.Parse(Console.ReadLine());
                    var prod = products.Find(p => p.Id == id);
                    if (prod != null)
                    {
                        Console.Write("New Stock: ");
                        prod.Stock = int.Parse(Console.ReadLine());
                        Console.WriteLine("Stock updated!");
                    }
                    break;

                case 4:
                    Console.Write("Product ID: ");
                    id = int.Parse(Console.ReadLine());
                    prod = products.Find(p => p.Id == id);
                    if (prod != null && prod.Stock > 0)
                    {
                        prod.Stock--;
                        Console.WriteLine($"Sold! Remaining: {prod.Stock}");
                    }
                    else
                    {
                        Console.WriteLine("Out of stock!");
                    }
                    break;

                case 5:
                    return;
            }
        }
    }
}