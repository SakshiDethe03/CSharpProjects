using System;
using System.Collections.Generic;

class Salary
{
    public string EmployeeName { get; set; }
    public decimal BasicSalary { get; set; }
    public decimal Allowances { get; set; }
    public decimal Deductions { get; set; }
    public decimal NetSalary { get; set; }
}

class Program
{
    static List<Salary> salaries = new List<Salary>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Payroll System ===");
            Console.WriteLine("1.Calculate Salary 2.View All 3.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Employee Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Basic Salary: ");
                    decimal basic = decimal.Parse(Console.ReadLine());
                    Console.Write("Allowances: ");
                    decimal allowances = decimal.Parse(Console.ReadLine());
                    Console.Write("Deductions: ");
                    decimal deductions = decimal.Parse(Console.ReadLine());
                    decimal net = basic + allowances - deductions;
                    salaries.Add(new Salary { EmployeeName = name, BasicSalary = basic, Allowances = allowances, Deductions = deductions, NetSalary = net });
                    Console.WriteLine($"Net Salary: ${net}");
                    break;

                case 2:
                    foreach (var s in salaries)
                        Console.WriteLine($"{s.EmployeeName} | Basic: ${s.BasicSalary} | Net: ${s.NetSalary}");
                    break;

                case 3:
                    return;
            }
        }
    }
}