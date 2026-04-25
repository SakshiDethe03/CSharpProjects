using System;
using System.Collections.Generic;

class Train
{
    public string TrainNumber { get; set; }
    public string From { get; set; }
    public string To { get; set; }
    public int Seats { get; set; }
}

class Program
{
    static List<Train> trains = new List<Train>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Railway Reservation ===");
            Console.WriteLine("1.Add Train 2.View Trains 3.Book 4.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Train Number: ");
                    string tn = Console.ReadLine();
                    Console.Write("From: ");
                    string from = Console.ReadLine();
                    Console.Write("To: ");
                    string to = Console.ReadLine();
                    Console.Write("Seats: ");
                    int seats = int.Parse(Console.ReadLine());
                    trains.Add(new Train { TrainNumber = tn, From = from, To = to, Seats = seats });
                    Console.WriteLine("Train added!");
                    break;

                case 2:
                    foreach (var t in trains)
                        Console.WriteLine($"{t.TrainNumber} | {t.From} -> {t.To} | Seats: {t.Seats}");
                    break;

                case 3:
                    Console.Write("Train Number: ");
                    tn = Console.ReadLine();
                    var train = trains.Find(t => t.TrainNumber == tn);
                    if (train != null && train.Seats > 0)
                    {
                        train.Seats--;
                        Console.WriteLine("Booked! Seats left: " + train.Seats);
                    }
                    else
                    {
                        Console.WriteLine("No seats available!");
                    }
                    break;

                case 4:
                    return;
            }
        }
    }
}