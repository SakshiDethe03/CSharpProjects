using System;
using System.Collections.Generic;

class GymMember
{
    public string Name { get; set; }
    public string MembershipType { get; set; }
    public DateTime JoinDate { get; set; }
    public bool Active { get; set; }
}

class Program
{
    static List<GymMember> members = new List<GymMember>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Gym Management ===");
            Console.WriteLine("1.Add Member 2.View All 3.Activate/Deactivate 4.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Type (Basic/Premium): ");
                    string type = Console.ReadLine();
                    members.Add(new GymMember { Name = name, MembershipType = type, JoinDate = DateTime.Now, Active = true });
                    Console.WriteLine("Member added!");
                    break;

                case 2:
                    foreach (var m in members)
                        Console.WriteLine($"{(m.Active ? "[Active]" : "[Inactive]")} {m.Name} | {m.MembershipType} | Joined: {m.JoinDate:yyyy-MM-dd}");
                    break;

                case 3:
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    var member = members.Find(m => m.Name == name);
                    if (member != null)
                    {
                        member.Active = !member.Active;
                        Console.WriteLine($"Status: {(member.Active ? "Active" : "Inactive")}");
                    }
                    break;

                case 4:
                    return;
            }
        }
    }
}