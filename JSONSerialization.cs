using System;
using System.Text.Json;

class Person
{
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        Person p = new Person { Name = "Sakshi" };

        string json = JsonSerializer.Serialize(p);
        Console.WriteLine(json);
    }
}