using System;
using System.Collections.Generic;

class Contact
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
}

class Program
{
    static List<Contact> contacts = new List<Contact>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Contact Manager ===");
            Console.WriteLine("1.Add Contact 2.View All 3.Search 4.Delete 5.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Phone: ");
                    string phone = Console.ReadLine();
                    Console.Write("Email: ");
                    string email = Console.ReadLine();
                    contacts.Add(new Contact { Name = name, Phone = phone, Email = email });
                    Console.WriteLine("Contact added!");
                    break;

                case 2:
                    foreach (var c in contacts)
                        Console.WriteLine($"{c.Name} | {c.Phone} | {c.Email}");
                    break;

                case 3:
                    Console.Write("Search name: ");
                    string search = Console.ReadLine();
                    var found = contacts.FindAll(c => c.Name.Contains(search));
                    foreach (var c in found)
                        Console.WriteLine($"{c.Name} | {c.Phone} | {c.Email}");
                    break;

                case 4:
                    Console.Write("Name to delete: ");
                    string del = Console.ReadLine();
                    contacts.RemoveAll(c => c.Name == del);
                    Console.WriteLine("Deleted!");
                    break;

                case 5:
                    return;
            }
        }
    }
}