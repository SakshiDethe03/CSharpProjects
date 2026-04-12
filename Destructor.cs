using System;

class Demo
{
    ~Demo()
    {
        Console.WriteLine("Destructor Called");
    }
}

class Program
{
    static void Main()
    {
        Demo d = new Demo();
    }
}