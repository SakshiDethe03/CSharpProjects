using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; set; }
    public bool Issued { get; set; }
}

class Program
{
    static List<Book> books = new List<Book>();

    static void Main()
    {
        books.Add(new Book { Title = "C#", Issued = false });

        foreach (var b in books)
            Console.WriteLine($"{b.Title} - {(b.Issued ? "Issued" : "Available")}");
    }
}