using System;
using System.Collections.Generic;

class Project
{
    public string Name { get; set; }
    public string Deadline { get; set; }
    public string Status { get; set; }
    public List<string> TeamMembers { get; set; }
}

class Program
{
    static List<Project> projects = new List<Project>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Project Tracker ===");
            Console.WriteLine("1.Create Project 2.View All 3.Add Member 4.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Project Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Deadline: ");
                    string deadline = Console.ReadLine();
                    projects.Add(new Project { Name = name, Deadline = deadline, Status = "In Progress", TeamMembers = new List<string>() });
                    Console.WriteLine("Project created!");
                    break;

                case 2:
                    foreach (var p in projects)
                    {
                        Console.WriteLine($"{p.Name} | {p.Deadline} | {p.Status}");
                        Console.WriteLine($"Team: {string.Join(", ", p.TeamMembers)}");
                    }
                    break;

                case 3:
                    Console.Write("Project Name: ");
                    name = Console.ReadLine();
                    Console.Write("Member Name: ");
                    string member = Console.ReadLine();
                    var proj = projects.Find(p => p.Name == name);
                    if (proj != null)
                    {
                        proj.TeamMembers.Add(member);
                        Console.WriteLine("Member added!");
                    }
                    break;

                case 4:
                    return;
            }
        }
    }
}