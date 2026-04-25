using System;
using System.Collections.Generic;

class Bus
{
    public string Route { get; set; }
    public string Time { get; set; }
    public int Seats { get; set; }
}

class Program
{
    static List<Bus> buses = new List<Bus>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Bus Reservation ===");
            Console.WriteLine("1.Add Bus 2.View Buses 3.Book 4.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Route: ");
                    string route = Console.ReadLine();
                    Console.Write("Time: ");
                    string time = Console.ReadLine();
                    Console.Write("Seats: ");
                    int seats = int.Parse(Console.ReadLine());
                    buses.Add(new Bus { Route = route, Time = time, Seats = seats });
                    Console.WriteLine("Bus added!");
                    break;

                case 2:
                    foreach (var b in buses)
                        Console.WriteLine($"{b.Route} | {b.Time} | Seats: {b.Seats}");
                    break;

                case 3:
                    Console.Write("Route: ");
                    route = Console.ReadLine();
                    var bus = buses.Find(b => b.Route == route);
                    if (bus != null && bus.Seats > 0)
                    {
                        bus.Seats--;
                        Console.WriteLine("Booked! Seats left: " + bus.Seats);
                    }
                    else
                    {
                        Console.WriteLine("No seats!");
                    }
                    break;

                case 4:
                    return;
            }
        }
    }
}