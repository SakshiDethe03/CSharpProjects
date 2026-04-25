using System;
using System.Collections.Generic;

class Post
{
    public string Content { get; set; }
    public string Author { get; set; }
    public int Likes { get; set; }
    public List<string> Comments { get; set; }
}

class Program
{
    static List<Post> posts = new List<Post>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Social Media ===");
            Console.WriteLine("1.Create Post 2.View Feed 3.Like 4.Comment 5.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Your Name: ");
                    string author = Console.ReadLine();
                    Console.Write("Post Content: ");
                    string content = Console.ReadLine();
                    posts.Add(new Post { Author = author, Content = content, Likes = 0, Comments = new List<string>() });
                    Console.WriteLine("Posted!");
                    break;

                case 2:
                    foreach (var p in posts)
                    {
                        Console.WriteLine($"@{p.Author}: {p.Content}");
                        Console.WriteLine($"Likes: {p.Likes}");
                        foreach (var c in p.Comments)
                            Console.WriteLine($"  Comment: {c}");
                    }
                    break;

                case 3:
                    Console.Write("Post # (1-based): ");
                    int idx = int.Parse(Console.ReadLine()) - 1;
                    if (idx >= 0 && idx < posts.Count)
                        posts[idx].Likes++;
                    break;

                case 4:
                    Console.Write("Post #: ");
                    idx = int.Parse(Console.ReadLine()) - 1;
                    if (idx >= 0 && idx < posts.Count)
                    {
                        Console.Write("Comment: ");
                        string comment = Console.ReadLine();
                        posts[idx].Comments.Add(comment);
                    }
                    break;

                case 5:
                    return;
            }
        }
    }
}