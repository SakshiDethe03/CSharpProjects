using System;
using System.Collections.Generic;

class Issue
{
    public string Title { get; set; }
    public string Priority { get; set; }
    public string Status { get; set; }
    public DateTime CreatedAt { get; set; }
}

class Program
{
    static List<Issue> issues = new List<Issue>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Bug Tracker ===");
            Console.WriteLine("1.Log Issue 2.View All 3.Update Status 4.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Issue Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Priority (Low/Medium/High): ");
                    string priority = Console.ReadLine();
                    issues.Add(new Issue { Title = title, Priority = priority, Status = "Open", CreatedAt = DateTime.Now });
                    Console.WriteLine("Issue logged!");
                    break;

                case 2:
                    foreach (var i in issues)
                        Console.WriteLine($"[{i.Status}] {i.Priority} - {i.Title}");
                    break;

                case 3:
                    Console.Write("Title: ");
                    title = Console.ReadLine();
                    var issue = issues.Find(i => i.Title == title);
                    if (issue != null)
                    {
                        Console.Write("New Status (Open/InProgress/Resolved): ");
                        issue.Status = Console.ReadLine();
                        Console.WriteLine("Status updated!");
                    }
                    break;

                case 4:
                    return;
            }
        }
    }
}