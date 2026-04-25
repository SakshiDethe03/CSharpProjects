using System;
using System.Collections.Generic;

class Course
{
    public string Code { get; set; }
    public string Name { get; set; }
    public int Credits { get; set; }
    public List<string> Students { get; set; }
}

class Program
{
    static List<Course> courses = new List<Course>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Course Registration ===");
            Console.WriteLine("1.Add Course 2.View Courses 3.Enroll Student 4.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Course Code: ");
                    string code = Console.ReadLine();
                    Console.Write("Course Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Credits: ");
                    int credits = int.Parse(Console.ReadLine());
                    courses.Add(new Course { Code = code, Name = name, Credits = credits, Students = new List<string>() });
                    Console.WriteLine("Course added!");
                    break;

                case 2:
                    foreach (var c in courses)
                    {
                        Console.WriteLine($"{c.Code} | {c.Name} | {c.Credits} Credits | Students: {c.Students.Count}");
                    }
                    break;

                case 3:
                    Console.Write("Course Code: ");
                    code = Console.ReadLine();
                    var course = courses.Find(c => c.Code == code);
                    if (course != null)
                    {
                        Console.Write("Student Name: ");
                        string student = Console.ReadLine();
                        course.Students.Add(student);
                        Console.WriteLine("Enrolled!");
                    }
                    break;

                case 4:
                    return;
            }
        }
    }
}