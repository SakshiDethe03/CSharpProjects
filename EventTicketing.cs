using System;
using System.Collections.Generic;

class Ticket
{
    public string EventName { get; set; }
    public string Attendee { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice { get; set; }
}

class Program
{
    static List<Ticket> tickets = new List<Ticket>();
    static decimal ticketPrice = 50;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Event Ticketing ===");
            Console.WriteLine("1.Buy Ticket 2.View Tickets 3.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Event Name: ");
                    string eventName = Console.ReadLine();
                    Console.Write("Attendee Name: ");
                    string attendee = Console.ReadLine();
                    Console.Write("Quantity: ");
                    int qty = int.Parse(Console.ReadLine());
                    decimal total = qty * ticketPrice;
                    tickets.Add(new Ticket { EventName = eventName, Attendee = attendee, Quantity = qty, TotalPrice = total });
                    Console.WriteLine($"Booked! Total: ${total}");
                    break;

                case 2:
                    foreach (var t in tickets)
                        Console.WriteLine($"{t.EventName} | {t.Attendee} | {t.Quantity} tickets | ${t.TotalPrice}");
                    break;

                case 3:
                    return;
            }
        }
    }
}