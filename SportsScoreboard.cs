using System;
using System.Collections.Generic;

class Player
{
    public string Name { get; set; }
    public string Sport { get; set; }
    public int Score { get; set; }
}

class Program
{
    static List<Player> players = new List<Player>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Sports Scoreboard ===");
            Console.WriteLine("1.Add Player 2.Update Score 3.Leaderboard 4.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Sport: ");
                    string sport = Console.ReadLine();
                    players.Add(new Player { Name = name, Sport = sport, Score = 0 });
                    Console.WriteLine("Player added!");
                    break;

                case 2:
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("Points: ");
                    int score = int.Parse(Console.ReadLine());
                    var p = players.Find(pl => pl.Name == name);
                    if (p != null)
                    {
                        p.Score += score;
                        Console.WriteLine("Score updated!");
                    }
                    break;

                case 3:
                    foreach (var pl in players.OrderByDescending(p => p.Score))
                        Console.WriteLine($"{pl.Name} | {pl.Sport} | {pl.Score} pts");
                    break;

                case 4:
                    return;
            }
        }
    }
}