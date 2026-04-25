using System;
using System.Collections.Generic;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }
}

class Program
{
    static List<Employee> employees = new List<Employee>();
    static int nextId = 1;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Employee Management ===");
            Console.WriteLine("1.Add 2.View All 3.Search 4.Update 5.Delete 6.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Department: ");
                    string dept = Console.ReadLine();
                    Console.Write("Salary: ");
                    decimal salary = decimal.Parse(Console.ReadLine());
                    employees.Add(new Employee { Id = nextId++, Name = name, Department = dept, Salary = salary });
                    Console.WriteLine("Employee added!");
                    break;

                case 2:
                    foreach (var e in employees)
                        Console.WriteLine($"{e.Id}. {e.Name} | {e.Department} | ${e.Salary}");
                    break;

                case 3:
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    foreach (var e in employees.FindAll(x => x.Name.Contains(name)))
                        Console.WriteLine($"{e.Id}. {e.Name} | {e.Department} | ${e.Salary}");
                    break;

                case 4:
                    Console.Write("ID: ");
                    int id = int.Parse(Console.ReadLine());
                    var emp = employees.Find(e => e.Id == id);
                    if (emp != null)
                    {
                        Console.Write("New Salary: ");
                        emp.Salary = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Updated!");
                    }
                    break;

                case 5:
                    Console.Write("ID: ");
                    id = int.Parse(Console.ReadLine());
                    employees.RemoveAll(e => e.Id == id);
                    Console.WriteLine("Deleted!");
                    break;

                case 6:
                    return;
            }
        }
    }
}