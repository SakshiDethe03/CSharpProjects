using System;
using System.Collections.Generic;

class Candidate
{
    public string Name { get; set; }
    public string Position { get; set; }
    public int Experience { get; set; }
    public string Status { get; set; }
}

class Program
{
    static List<Candidate> candidates = new List<Candidate>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Recruitment System ===");
            Console.WriteLine("1.Add Candidate 2.View All 3.Schedule Interview 4.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Position: ");
                    string pos = Console.ReadLine();
                    Console.Write("Experience (years): ");
                    int exp = int.Parse(Console.ReadLine());
                    candidates.Add(new Candidate { Name = name, Position = pos, Experience = exp, Status = "Applied" });
                    Console.WriteLine("Candidate added!");
                    break;

                case 2:
                    foreach (var c in candidates)
                        Console.WriteLine($"{c.Name} | {c.Position} | {c.Experience} yrs | {c.Status}");
                    break;

                case 3:
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    var cand = candidates.Find(c => c.Name == name);
                    if (cand != null)
                    {
                        cand.Status = "Interview Scheduled";
                        Console.WriteLine("Interview scheduled!");
                    }
                    break;

                case 4:
                    return;
            }
        }
    }
}