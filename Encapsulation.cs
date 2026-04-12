using System;

class Student
{
    private int age;

    public void SetAge(int a)
    {
        age = a;
    }

    public int GetAge()
    {
        return age;
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.SetAge(20);

        Console.WriteLine(s.GetAge());
    }
}