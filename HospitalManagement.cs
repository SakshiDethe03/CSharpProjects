using System;
using System.Collections.Generic;

class Patient
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Ailment { get; set; }
    public string Ward { get; set; }
}

class Program
{
    static List<Patient> patients = new List<Patient>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Hospital Management ===");
            Console.WriteLine("1.Admit Patient 2.View Patients 3.Discharge 4.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Age: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.Write("Ailment: ");
                    string ailment = Console.ReadLine();
                    Console.Write("Ward: ");
                    string ward = Console.ReadLine();
                    patients.Add(new Patient { Name = name, Age = age, Ailment = ailment, Ward = ward });
                    Console.WriteLine("Patient admitted!");
                    break;

                case 2:
                    foreach (var p in patients)
                        Console.WriteLine($"{p.Name} | {p.Age} | {p.Ailment} | Ward: {p.Ward}");
                    break;

                case 3:
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    patients.RemoveAll(p => p.Name == name);
                    Console.WriteLine("Patient discharged!");
                    break;

                case 4:
                    return;
            }
        }
    }
}