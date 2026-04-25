using System;
using System.Collections.Generic;

class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public string Product { get; set; }
    public int Quantity { get; set; }
    public decimal Total { get; set; }
    public string Status { get; set; }
}

class Program
{
    static List<Order> orders = new List<Order>();
    static int nextId = 1;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Order Management ===");
            Console.WriteLine("1.New Order 2.View All 3.Update Status 4.Cancel 5.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Customer: ");
                    string customer = Console.ReadLine();
                    Console.Write("Product: ");
                    string product = Console.ReadLine();
                    Console.Write("Quantity: ");
                    int qty = int.Parse(Console.ReadLine());
                    Console.Write("Unit Price: ");
                    decimal price = decimal.Parse(Console.ReadLine());
                    orders.Add(new Order
                    {
                        OrderId = nextId++,
                        CustomerName = customer,
                        Product = product,
                        Quantity = qty,
                        Total = qty * price,
                        Status = "Pending"
                    });
                    Console.WriteLine($"Order #{nextId - 1} placed! Total: ${orders[orders.Count - 1].Total}");
                    break;

                case 2:
                    foreach (var o in orders)
                        Console.WriteLine($"#{o.OrderId} | {o.CustomerName} | {o.Product} x{o.Quantity} | ${o.Total} | {o.Status}");
                    break;

                case 3:
                    Console.Write("Order ID: ");
                    int id = int.Parse(Console.ReadLine());
                    var ord = orders.Find(o => o.OrderId == id);
                    if (ord != null)
                    {
                        Console.Write("Status (Processing/Shipped/Delivered): ");
                        ord.Status = Console.ReadLine();
                        Console.WriteLine("Status updated!");
                    }
                    break;

                case 4:
                    Console.Write("Order ID: ");
                    id = int.Parse(Console.ReadLine());
                    orders.RemoveAll(o => o.OrderId == id);
                    Console.WriteLine("Order cancelled!");
                    break;

                case 5:
                    return;
            }
        }
    }
}