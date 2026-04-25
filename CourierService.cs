using System;
using System.Collections.Generic;

class Shipment
{
    public string OrderId { get; set; }
    public string Destination { get; set; }
    public string Status { get; set; }
    public DateTime ShipDate { get; set; }
}

class Program
{
    static List<Shipment> shipments = new List<Shipment>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Courier Service ===");
            Console.WriteLine("1.Create Shipment 2.Track 3.Update Status 4.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Order ID: ");
                    string orderId = Console.ReadLine();
                    Console.Write("Destination: ");
                    string dest = Console.ReadLine();
                    shipments.Add(new Shipment { OrderId = orderId, Destination = dest, Status = "Shipped", ShipDate = DateTime.Now });
                    Console.WriteLine("Shipment created!");
                    break;

                case 2:
                    Console.Write("Order ID: ");
                    orderId = Console.ReadLine();
                    var s = shipments.Find(x => x.OrderId == orderId);
                    if (s != null)
                        Console.WriteLine($"{s.Status} | {s.Destination} | Shipped: {s.ShipDate}");
                    break;

                case 3:
                    Console.Write("Order ID: ");
                    orderId = Console.ReadLine();
                    s = shipments.Find(x => x.OrderId == orderId);
                    if (s != null)
                    {
                        Console.Write("New Status (InTransit/Delivered): ");
                        s.Status = Console.ReadLine();
                        Console.WriteLine("Updated!");
                    }
                    break;

                case 4:
                    return;
            }
        }
    }
}