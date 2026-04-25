using System;
using System.Collections.Generic;

class Flight
{
    public string FlightNumber { get; set; }
    public string Destination { get; set; }
    public string Time { get; set; }
    public int SeatsAvailable { get; set; }
}

class Program
{
    static List<Flight> flights = new List<Flight>();

    static void Main()
    {
        flights.Add(new Flight { FlightNumber = "AI101", Destination = "Delhi", Time = "10:00", SeatsAvailable = 100 });
        flights.Add(new Flight { FlightNumber = "AI102", Destination = "Mumbai", Time = "14:00", SeatsAvailable = 100 });

        while (true)
        {
            Console.WriteLine("\n=== Flight Booking ===");
            Console.WriteLine("1.View Flights 2.Book Seat 3.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    foreach (var f in flights)
                        Console.WriteLine($"{f.FlightNumber} | {f.Destination} | {f.Time} | Seats: {f.SeatsAvailable}");
                    break;

                case 2:
                    Console.Write("Flight Number: ");
                    string fn = Console.ReadLine();
                    var flight = flights.Find(f => f.FlightNumber == fn);
                    if (flight != null && flight.SeatsAvailable > 0)
                    {
                        flight.SeatsAvailable--;
                        Console.WriteLine("Booked! Seats left: " + flight.SeatsAvailable);
                    }
                    else
                    {
                        Console.WriteLine("No seats available!");
                    }
                    break;

                case 3:
                    return;
            }
        }
    }
}