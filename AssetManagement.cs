using System;
using System.Collections.Generic;

class Asset
{
    public string Name { get; set; }
    public string Type { get; set; }
    public decimal Value { get; set; }
    public string AssignedTo { get; set; }
}

class Program
{
    static List<Asset> assets = new List<Asset>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Asset Management ===");
            Console.WriteLine("1.Add Asset 2.View All 3.Assign 4.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Asset Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Type (Laptop/Phone/Furniture): ");
                    string type = Console.ReadLine();
                    Console.Write("Value: ");
                    decimal value = decimal.Parse(Console.ReadLine());
                    assets.Add(new Asset { Name = name, Type = type, Value = value });
                    Console.WriteLine("Asset added!");
                    break;

                case 2:
                    foreach (var a in assets)
                        Console.WriteLine($"{a.Name} | {a.Type} | ${a.Value} | {(string.IsNullOrEmpty(a.AssignedTo) ? "Unassigned" : a.AssignedTo)}");
                    break;

                case 3:
                    Console.Write("Asset Name: ");
                    name = Console.ReadLine();
                    Console.Write("Assign To: ");
                    string person = Console.ReadLine();
                    var asset = assets.Find(a => a.Name == name);
                    if (asset != null)
                    {
                        asset.AssignedTo = person;
                        Console.WriteLine("Assigned!");
                    }
                    break;

                case 4:
                    return;
            }
        }
    }
}