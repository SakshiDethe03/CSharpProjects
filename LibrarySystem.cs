using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public bool Available { get; set; }
    public string BorrowedBy { get; set; }
}

class Program
{
    static List<Book> library = new List<Book>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Library System ===");
            Console.WriteLine("1.Add Book 2.View Books 3.Borrow 4.Return 5.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Author: ");
                    string author = Console.ReadLine();
                    library.Add(new Book { Title = title, Author = author, Available = true });
                    Console.WriteLine("Book added!");
                    break;

                case 2:
                    foreach (var b in library)
                        Console.WriteLine($"{(b.Available ? "[Available]" : "[Borrowed by " + b.BorrowedBy + "]")} {b.Title} by {b.Author}");
                    break;

                case 3:
                    Console.Write("Title: ");
                    title = Console.ReadLine();
                    Console.Write("Borrower: ");
                    string borrower = Console.ReadLine();
                    var book = library.Find(b => b.Title == title);
                    if (book != null && book.Available)
                    {
                        book.Available = false;
                        book.BorrowedBy = borrower;
                        Console.WriteLine("Book borrowed!");
                    }
                    break;

                case 4:
                    Console.Write("Title: ");
                    title = Console.ReadLine();
                    book = library.Find(b => b.Title == title);
                    if (book != null)
                    {
                        book.Available = true;
                        book.BorrowedBy = null;
                        Console.WriteLine("Book returned!");
                    }
                    break;

                case 5:
                    return;
            }
        }
    }
}