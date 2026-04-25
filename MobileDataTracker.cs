using System;
using System.Collections.Generic;

class Customer
{
    public string Name { get; set; }
    public string Plan { get; set; }
    public int DataUsed { get; set; }
    public int DataLimit { get; set; }
}

class Program
{
    static List<Customer> customers = new List<Customer>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Mobile Data Tracker ===");
            Console.WriteLine("1.Add Customer 2.Use Data 3.View All 4.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Plan (1GB/5GB/Unlimited): ");
                    string plan = Console.ReadLine();
                    int limit = plan == "Unlimited" ? 99999 : plan == "5GB" ? 5000 : 1000;
                    customers.Add(new Customer { Name = name, Plan = plan, DataLimit = limit, DataUsed = 0 });
                    Console.WriteLine("Customer added!");
                    break;

                case 2:
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("MB Used: ");
                    int mb = int.Parse(Console.ReadLine());
                    var c = customers.Find(x => x.Name == name);
                    if (c != null)
                    {
                        c.DataUsed += mb;
                        Console.WriteLine($"Used: {c.DataUsed}MB / {c.DataLimit}MB");
                    }
                    break;

                case 3:
                    foreach (var c in customers)
                        Console.WriteLine($"{c.Name} | {c.Plan} | {c.DataUsed}/{c.DataLimit}MB");
                    break;

                case 4:
                    return;
            }
        }
    }
}