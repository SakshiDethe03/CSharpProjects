using System;
using System.Collections.Generic;

class Note
{
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
}

class Program
{
    static List<Note> notes = new List<Note>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Notes App ===");
            Console.WriteLine("1.Create Note 2.View All 3.Search 4.Delete 5.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Content: ");
                    string content = Console.ReadLine();
                    notes.Add(new Note { Title = title, Content = content, CreatedAt = DateTime.Now });
                    Console.WriteLine("Note saved!");
                    break;

                case 2:
                    foreach (var n in notes)
                    {
                        Console.WriteLine($"\n[{n.Title}] - {n.CreatedAt}");
                        Console.WriteLine(n.Content);
                    }
                    break;

                case 3:
                    Console.Write("Search: ");
                    string search = Console.ReadLine();
                    foreach (var n in notes.FindAll(x => x.Title.Contains(search) || x.Content.Contains(search)))
                    {
                        Console.WriteLine($"\n[{n.Title}] - {n.CreatedAt}");
                        Console.WriteLine(n.Content);
                    }
                    break;

                case 4:
                    Console.Write("Title to delete: ");
                    title = Console.ReadLine();
                    notes.RemoveAll(n => n.Title == title);
                    Console.WriteLine("Deleted!");
                    break;

                case 5:
                    return;
            }
        }
    }
}