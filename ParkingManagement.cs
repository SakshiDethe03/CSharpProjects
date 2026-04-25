using System;
using System.Collections.Generic;

class ParkingSlot
{
    public string SlotNumber { get; set; }
    public string VehicleNumber { get; set; }
    public DateTime EntryTime { get; set; }
    public bool Occupied { get; set; }
}

class Program
{
    static List<ParkingSlot> parking = new List<ParkingSlot>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Parking Management ===");
            Console.WriteLine("1.Park Vehicle 2.Remove Vehicle 3.View Slots 4.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Slot Number: ");
                    string slot = Console.ReadLine();
                    Console.Write("Vehicle Number: ");
                    string vehicle = Console.ReadLine();
                    parking.Add(new ParkingSlot { SlotNumber = slot, VehicleNumber = vehicle, EntryTime = DateTime.Now, Occupied = true });
                    Console.WriteLine("Vehicle parked!");
                    break;

                case 2:
                    Console.Write("Slot Number: ");
                    slot = Console.ReadLine();
                    var p = parking.Find(x => x.SlotNumber == slot);
                    if (p != null)
                    {
                        TimeSpan duration = DateTime.Now - p.EntryTime;
                        decimal charges = (decimal)duration.TotalHours * 10;
                        Console.WriteLine($"Duration: {duration.TotalMinutes:F0} mins | Charges: ${charges:F2}");
                        parking.Remove(p);
                    }
                    break;

                case 3:
                    foreach (var p in parking)
                        Console.WriteLine($"Slot {p.SlotNumber}: {p.VehicleNumber}");
                    break;

                case 4:
                    return;
            }
        }
    }
}