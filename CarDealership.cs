using System;
using System.Collections.Generic;

class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; }
    public bool Sold { get; set; }
}

class Program
{
    static List<Vehicle> vehicles = new List<Vehicle>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Car Dealership ===");
            Console.WriteLine("1.Add Vehicle 2.View All 3.Mark Sold 4.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Make: ");
                    string make = Console.ReadLine();
                    Console.Write("Model: ");
                    string model = Console.ReadLine();
                    Console.Write("Year: ");
                    int year = int.Parse(Console.ReadLine());
                    Console.Write("Price: ");
                    decimal price = decimal.Parse(Console.ReadLine());
                    vehicles.Add(new Vehicle { Make = make, Model = model, Year = year, Price = price });
                    Console.WriteLine("Vehicle added!");
                    break;

                case 2:
                    foreach (var v in vehicles)
                        Console.WriteLine($"{(v.Sold ? "[SOLD]" : "[AVAILABLE]")} {v.Year} {v.Make} {v.Model} - ${v.Price}");
                    break;

                case 3:
                    Console.Write("Model: ");
                    model = Console.ReadLine();
                    var vehicle = vehicles.Find(v => v.Model == model);
                    if (vehicle != null)
                    {
                        vehicle.Sold = true;
                        Console.WriteLine("Marked as sold!");
                    }
                    break;

                case 4:
                    return;
            }
        }
    }
}