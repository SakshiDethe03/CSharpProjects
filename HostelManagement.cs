using System;
using System.Collections.Generic;

class Room
{
    public int RoomNumber { get; set; }
    public string Type { get; set; }
    public decimal Price { get; set; }
    public bool Occupied { get; set; }
}

class Program
{
    static List<Room> rooms = new List<Room>();

    static void Main()
    {
        for (int i = 101; i <= 110; i++)
            rooms.Add(new Room { RoomNumber = i, Type = "Standard", Price = 1000, Occupied = false });

        while (true)
        {
            Console.WriteLine("\n=== Hostel Management ===");
            Console.WriteLine("1.View Rooms 2.Check In 3.Check Out 4.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    foreach (var r in rooms)
                        Console.WriteLine($"Room {r.RoomNumber} | {r.Type} | ${r.Price} | {(r.Occupied ? "Occupied" : "Available")}");
                    break;

                case 2:
                    Console.Write("Room Number: ");
                    int num = int.Parse(Console.ReadLine());
                    var room = rooms.Find(r => r.RoomNumber == num);
                    if (room != null && !room.Occupied)
                    {
                        room.Occupied = true;
                        Console.WriteLine("Checked in!");
                    }
                    break;

                case 3:
                    Console.Write("Room Number: ");
                    num = int.Parse(Console.ReadLine());
                    room = rooms.Find(r => r.RoomNumber == num);
                    if (room != null && room.Occupied)
                    {
                        room.Occupied = false;
                        Console.WriteLine("Checked out!");
                    }
                    break;

                case 4:
                    return;
            }
        }
    }
}