using System;
using System.Collections.Generic;

class Exam
{
    public string Subject { get; set; }
    public DateTime Date { get; set; }
    public string Time { get; set; }
    public string Venue { get; set; }
}

class Program
{
    static List<Exam> exams = new List<Exam>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Exam Schedule ===");
            Console.WriteLine("1.Add Exam 2.View Schedule 3.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Subject: ");
                    string subject = Console.ReadLine();
                    Console.Write("Date (yyyy-MM-dd): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    Console.Write("Time: ");
                    string time = Console.ReadLine();
                    Console.Write("Venue: ");
                    string venue = Console.ReadLine();
                    exams.Add(new Exam { Subject = subject, Date = date, Time = time, Venue = venue });
                    Console.WriteLine("Exam scheduled!");
                    break;

                case 2:
                    foreach (var e in exams.OrderBy(x => x.Date))
                        Console.WriteLine($"{e.Date:yyyy-MM-dd} | {e.Time} | {e.Subject} | {e.Venue}");
                    break;

                case 3:
                    return;
            }
        }
    }
}