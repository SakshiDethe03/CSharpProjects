using System;

class Student
{
    public string name = "Sakshi";
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        Console.WriteLine(s.name);
    }
}