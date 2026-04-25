using System;
using System.Collections.Generic;

class Movie
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public int Rating { get; set; }
    public bool Watched { get; set; }
}

class Program
{
    static List<Movie> movies = new List<Movie>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Movie Tracker ===");
            Console.WriteLine("1.Add Movie 2.View All 3.Mark Watched 4.By Genre 5.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Genre: ");
                    string genre = Console.ReadLine();
                    Console.Write("Rating (1-5): ");
                    int rating = int.Parse(Console.ReadLine());
                    movies.Add(new Movie { Title = title, Genre = genre, Rating = rating });
                    Console.WriteLine("Movie added!");
                    break;

                case 2:
                    foreach (var m in movies)
                        Console.WriteLine($"{(m.Watched ? "[X]" : "[ ]")} {m.Title} | {m.Genre} | {m.Rating}/5");
                    break;

                case 3:
                    Console.Write("Title: ");
                    title = Console.ReadLine();
                    var movie = movies.Find(m => m.Title == title);
                    if (movie != null)
                    {
                        movie.Watched = true;
                        Console.WriteLine("Marked as watched!");
                    }
                    break;

                case 4:
                    Console.Write("Genre: ");
                    genre = Console.ReadLine();
                    foreach (var m in movies.FindAll(x => x.Genre == genre))
                        Console.WriteLine($"{(m.Watched ? "[X]" : "[ ]")} {m.Title} | {m.Rating}/5");
                    break;

                case 5:
                    return;
            }
        }
    }
}