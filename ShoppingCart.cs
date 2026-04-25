using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}

class CartItem
{
    public Product Product { get; set; }
    public int Qty { get; set; }
}

class Program
{
    static List<Product> products = new List<Product>
    {
        new Product { Name = "Apple", Price = 0.50m },
        new Product { Name = "Banana", Price = 0.30m },
        new Product { Name = "Milk", Price = 2.00m },
        new Product { Name = "Bread", Price = 1.50m }
    };
    static List<CartItem> cart = new List<CartItem>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Shopping Cart ===");
            Console.WriteLine("1.View Products 2.Add to Cart 3.View Cart 4.Checkout 5.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    foreach (var p in products)
                        Console.WriteLine($"{p.Name} - ${p.Price}");
                    break;

                case 2:
                    Console.Write("Product Name: ");
                    string name = Console.ReadLine();
                    var prod = products.Find(p => p.Name == name);
                    if (prod != null)
                    {
                        Console.Write("Quantity: ");
                        int qty = int.Parse(Console.ReadLine());
                        cart.Add(new CartItem { Product = prod, Qty = qty });
                        Console.WriteLine("Added to cart!");
                    }
                    break;

                case 3:
                    decimal total = 0;
                    foreach (var c in cart)
                    {
                        decimal lineTotal = c.Product.Price * c.Qty;
                        Console.WriteLine($"{c.Product.Name} x{c.Qty} = ${lineTotal}");
                        total += lineTotal;
                    }
                    Console.WriteLine($"Total: ${total}");
                    break;

                case 4:
                    total = 0;
                    foreach (var c in cart) total += c.Product.Price * c.Qty;
                    Console.WriteLine($"Paid ${total}! Thank you!");
                    cart.Clear();
                    break;

                case 5:
                    return;
            }
        }
    }
}