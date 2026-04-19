using System;

class Employee
{
    public double Basic;

    public double Salary()
    {
        double hra = Basic * 0.2;
        double da = Basic * 0.1;
        return Basic + hra + da;
    }
}

class Program
{
    static void Main()
    {
        Employee e = new Employee { Basic = 10000 };
        Console.WriteLine("Salary: " + e.Salary());
    }
}