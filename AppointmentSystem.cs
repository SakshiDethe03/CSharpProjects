using System;
using System.Collections.Generic;

class Appointment
{
    public string PatientName { get; set; }
    public string Doctor { get; set; }
    public DateTime DateTime { get; set; }
}

class Program
{
    static List<Appointment> appointments = new List<Appointment>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Appointment System ===");
            Console.WriteLine("1.Book 2.View All 3.By Doctor 4.Cancel 5.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Patient Name: ");
                    string patient = Console.ReadLine();
                    Console.Write("Doctor: ");
                    string doctor = Console.ReadLine();
                    Console.Write("DateTime (yyyy-MM-dd HH:mm): ");
                    DateTime dt = DateTime.Parse(Console.ReadLine());
                    appointments.Add(new Appointment { PatientName = patient, Doctor = doctor, DateTime = dt });
                    Console.WriteLine("Appointment booked!");
                    break;

                case 2:
                    foreach (var a in appointments)
                        Console.WriteLine($"{a.DateTime} | {a.Doctor} | {a.PatientName}");
                    break;

                case 3:
                    Console.Write("Doctor Name: ");
                    doctor = Console.ReadLine();
                    foreach (var a in appointments.FindAll(x => x.Doctor == doctor))
                        Console.WriteLine($"{a.DateTime} | {a.PatientName}");
                    break;

                case 4:
                    Console.Write("Patient Name: ");
                    patient = Console.ReadLine();
                    appointments.RemoveAll(a => a.PatientName == patient);
                    Console.WriteLine("Appointment cancelled!");
                    break;

                case 5:
                    return;
            }
        }
    }
}