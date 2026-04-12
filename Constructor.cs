using System;

class Student
{
    public Student()
    {
        Console.WriteLine("Constructor Called");
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
    }
}