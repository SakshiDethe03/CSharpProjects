using System;
using System.Collections.Generic;

class MenuItem
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
}

class Order
{
    public List<MenuItem> Items { get; set; }
    public decimal Total { get; set; }
}

class Program
{
    static List<MenuItem> menu = new List<MenuItem>
    {
        new MenuItem { Name = "Burger", Price = 150, Category = "Main" },
        new MenuItem { Name = "Pizza", Price = 300, Category = "Main" },
        new MenuItem { Name = "Cola", Price = 50, Category = "Drink" },
        new MenuItem { Name = "Fries", Price = 80, Category = "Snack" }
    };
    static List<Order> orders = new List<Order>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Restaurant POS ===");
            Console.WriteLine("1.View Menu 2.New Order 3.View Orders 4.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    foreach (var m in menu)
                        Console.WriteLine($"{m.Name} - ${m.Price} ({m.Category})");
                    break;

                case 2:
                    var order = new Order { Items = new List<MenuItem>() };
                    while (true)
                    {
                        Console.Write("Item (done to finish): ");
                        string item = Console.ReadLine();
                        if (item == "done") break;
                        var mi = menu.Find(m => m.Name == item);
                        if (mi != null) order.Items.Add(mi);
                    }
                    order.Total = 0;
                    foreach (var i in order.Items) order.Total += i.Price;
                    orders.Add(order);
                    Console.WriteLine($"Order Total: ${order.Total}");
                    break;

                case 3:
                    int i = 1;
                    foreach (var o in orders)
                    {
                        Console.WriteLine($"Order #{i++} - ${o.Total}");
                    }
                    break;

                case 4:
                    return;
            }
        }
    }
}