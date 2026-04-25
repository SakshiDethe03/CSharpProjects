using System;
using System.Collections.Generic;

class Subscriber
{
    public string Name { get; set; }
    public string Plan { get; set; }
    public DateTime RenewalDate { get; set; }
}

class Program
{
    static List<Subscriber> subscribers = new List<Subscriber>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Subscription Manager ===");
            Console.WriteLine("1.Add Subscriber 2.View All 3.Renew 4.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Plan (Basic/Premium/Pro): ");
                    string plan = Console.ReadLine();
                    Console.Write("Renewal (yyyy-MM-dd): ");
                    DateTime renewal = DateTime.Parse(Console.ReadLine());
                    subscribers.Add(new Subscriber { Name = name, Plan = plan, RenewalDate = renewal });
                    Console.WriteLine("Subscriber added!");
                    break;

                case 2:
                    foreach (var s in subscribers)
                        Console.WriteLine($"{s.Name} | {s.Plan} | Renews: {s.RenewalDate:yyyy-MM-dd}");
                    break;

                case 3:
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    var sub = subscribers.Find(s => s.Name == name);
                    if (sub != null)
                    {
                        sub.RenewalDate = sub.RenewalDate.AddMonths(1);
                        Console.WriteLine($"Renewed! New date: {sub.RenewalDate:yyyy-MM-dd}");
                    }
                    break;

                case 4:
                    return;
            }
        }
    }
}