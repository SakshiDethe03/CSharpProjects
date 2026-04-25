using System;
using System.Collections.Generic;

class Customer
{
    public string Name { get; set; }
    public string Plan { get; set; }
    public decimal Bill { get; set; }
    public bool Paid { get; set; }
}

class Program
{
    static List<Customer> customers = new List<Customer>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Electricity Bill ===");
            Console.WriteLine("1.Add Customer 2.Generate Bill 3.View Bills 4.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Plan (Residential/Commercial): ");
                    string plan = Console.ReadLine();
                    customers.Add(new Customer { Name = name, Plan = plan, Paid = false });
                    Console.WriteLine("Customer added!");
                    break;

                case 2:
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("Units Consumed: ");
                    int units = int.Parse(Console.ReadLine());
                    var cust = customers.Find(c => c.Name == name);
                    if (cust != null)
                    {
                        decimal rate = cust.Plan == "Residential" ? 0.10m : 0.15m;
                        cust.Bill = units * rate;
                        Console.WriteLine($"Bill: ${cust.Bill}");
                    }
                    break;

                case 3:
                    foreach (var c in customers)
                        Console.WriteLine($"{c.Name} | {c.Plan} | ${c.Bill} | {(c.Paid ? "Paid" : "Unpaid")}");
                    break;

                case 4:
                    return;
            }
        }
    }
}