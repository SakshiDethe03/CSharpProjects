using System;
using System.Collections.Generic;

class Subscriber
{
    public string Name { get; set; }
    public string Channel { get; set; }
}

class Video
{
    public string Title { get; set; }
    public string Channel { get; set; }
    public int Views { get; set; }
    public int Likes { get; set; }
}

class Program
{
    static List<Video> videos = new List<Video>();
    static List<Subscriber> subscribers = new List<Subscriber>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== YouTube Clone ===");
            Console.WriteLine("1.Upload Video 2.Subscribe 3.View Videos 4.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Channel: ");
                    string channel = Console.ReadLine();
                    videos.Add(new Video { Title = title, Channel = channel, Views = 0, Likes = 0 });
                    Console.WriteLine("Video uploaded!");
                    break;

                case 2:
                    Console.Write("Your Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Channel: ");
                    channel = Console.ReadLine();
                    subscribers.Add(new Subscriber { Name = name, Channel = channel });
                    Console.WriteLine("Subscribed!");
                    break;

                case 3:
                    foreach (var v in videos)
                        Console.WriteLine($"{v.Title} | {v.Channel} | {v.Likes} likes");
                    break;

                case 4:
                    return;
            }
        }
    }
}