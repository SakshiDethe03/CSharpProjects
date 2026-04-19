using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Program
{
    static List<Student> students = new List<Student>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1.Add 2.View 3.Update 4.Delete 5.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Id: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    students.Add(new Student { Id = id, Name = name });
                    break;

                case 2:
                    foreach (var s in students)
                        Console.WriteLine($"{s.Id} - {s.Name}");
                    break;

                case 3:
                    Console.Write("Enter Id to update: ");
                    id = int.Parse(Console.ReadLine());
                    var stu = students.FirstOrDefault(x => x.Id == id);
                    if (stu != null)
                    {
                        Console.Write("New Name: ");
                        stu.Name = Console.ReadLine();
                    }
                    break;

                case 4:
                    Console.Write("Enter Id to delete: ");
                    id = int.Parse(Console.ReadLine());
                    students.RemoveAll(x => x.Id == id);
                    break;

                case 5: return;
            }
        }
    }
}