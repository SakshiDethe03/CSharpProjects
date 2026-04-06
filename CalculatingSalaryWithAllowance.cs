using System;

class Program
{
    static void Main(string[] args)
    {
        double basic, hra, da, total;

        Console.Write("Enter basic salary: ");
        basic = Convert.ToDouble(Console.ReadLine());

        // Allowances (example percentages)
        hra = basic * 0.20; // 20% HRA
        da = basic * 0.10;  // 10% DA

        total = basic + hra + da;

        Console.WriteLine("HRA = " + hra);
        Console.WriteLine("DA = " + da);
        Console.WriteLine("Total Salary = " + total);
    }
}