using System;
using System.Collections.Generic;

class Candidate
{
    public string Name { get; set; }
    public int Votes { get; set; }
}

class Program
{
    static List<Candidate> candidates = new List<Candidate>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Voting System ===");
            Console.WriteLine("1.Add Candidate 2.Vote 3.View Results 4.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Candidate Name: ");
                    string name = Console.ReadLine();
                    candidates.Add(new Candidate { Name = name, Votes = 0 });
                    Console.WriteLine("Candidate added!");
                    break;

                case 2:
                    Console.Write("Candidate Name: ");
                    name = Console.ReadLine();
                    var cand = candidates.Find(c => c.Name == name);
                    if (cand != null)
                    {
                        cand.Votes++;
                        Console.WriteLine("Voted!");
                    }
                    else
                    {
                        Console.WriteLine("Candidate not found!");
                    }
                    break;

                case 3:
                    foreach (var c in candidates)
                        Console.WriteLine($"{c.Name}: {c.Votes} votes");
                    break;

                case 4:
                    return;
            }
        }
    }
}