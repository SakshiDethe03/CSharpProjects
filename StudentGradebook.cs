using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int[] Marks { get; set; }
    public double Average { get; set; }
    public string Grade { get; set; }
}

class Program
{
    static List<Student> students = new List<Student>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Student Gradebook ===");
            Console.WriteLine("1.Add Student 2.View All 3.Top Student 4.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter 3 marks separated by space: ");
                    string[] marksStr = Console.ReadLine().Split(' ');
                    int[] marks = new int[3];
                    for (int i = 0; i < 3; i++) marks[i] = int.Parse(marksStr[i]);
                    double avg = (marks[0] + marks[1] + marks[2]) / 3.0;
                    string grade = avg >= 90 ? "A" : avg >= 80 ? "B" : avg >= 70 ? "C" : avg >= 60 ? "D" : "F";
                    students.Add(new Student { Name = name, Marks = marks, Average = avg, Grade = grade });
                    Console.WriteLine($"Grade: {grade}");
                    break;

                case 2:
                    foreach (var s in students)
                        Console.WriteLine($"{s.Name} | Avg: {s.Average:F1} | Grade: {s.Grade}");
                    break;

                case 3:
                    var top = students.OrderByDescending(s => s.Average).First();
                    Console.WriteLine($"Top Student: {top.Name} with {top.Average:F1}");
                    break;

                case 4:
                    return;
            }
        }
    }
}