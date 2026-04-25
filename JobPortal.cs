using System;
using System.Collections.Generic;

class Job
{
    public string Title { get; set; }
    public string Company { get; set; }
    public decimal Salary { get; set; }
    public string Location { get; set; }
}

class Program
{
    static List<Job> jobs = new List<Job>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Job Portal ===");
            Console.WriteLine("1.Post Job 2.View Jobs 3.Search by Location 4.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Job Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Company: ");
                    string company = Console.ReadLine();
                    Console.Write("Salary: ");
                    decimal salary = decimal.Parse(Console.ReadLine());
                    Console.Write("Location: ");
                    string location = Console.ReadLine();
                    jobs.Add(new Job { Title = title, Company = company, Salary = salary, Location = location });
                    Console.WriteLine("Job posted!");
                    break;

                case 2:
                    foreach (var j in jobs)
                        Console.WriteLine($"{j.Title} | {j.Company} | ${j.Salary} | {j.Location}");
                    break;

                case 3:
                    Console.Write("Location: ");
                    location = Console.ReadLine();
                    foreach (var j in jobs.FindAll(x => x.Location == location))
                        Console.WriteLine($"{j.Title} | {j.Company} | ${j.Salary}");
                    break;

                case 4:
                    return;
            }
        }
    }
}