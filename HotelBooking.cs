using System;
using System.Collections.Generic;

class HotelBooking
{
    public string GuestName { get; set; }
    public string RoomType { get; set; }
    public int Nights { get; set; }
    public decimal TotalCost { get; set; }
}

class Program
{
    static List<HotelBooking> bookings = new List<HotelBooking>();
    static decimal[] rates = { 100, 150, 200 }; // Standard, Deluxe, Suite

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Hotel Booking ===");
            Console.WriteLine("1.Book Room 2.View Bookings 3.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Guest Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Room Type (1.Standard $100, 2.Deluxe $150, 3.Suite $200): ");
                    int type = int.Parse(Console.ReadLine());
                    Console.Write("Nights: ");
                    int nights = int.Parse(Console.ReadLine());
                    decimal cost = rates[type - 1] * nights;
                    bookings.Add(new HotelBooking { GuestName = name, RoomType = ((string[])new[] { "Standard", "Deluxe", "Suite" })[type - 1], Nights = nights, TotalCost = cost });
                    Console.WriteLine($"Booked! Total: ${cost}");
                    break;

                case 2:
                    foreach (var b in bookings)
                        Console.WriteLine($"{b.GuestName} | {b.RoomType} | {b.Nights} nights | ${b.TotalCost}");
                    break;

                case 3:
                    return;
            }
        }
    }
}