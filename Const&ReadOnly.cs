using System;

class Program
{
    // readonly variable
    readonly int x;

    // constructor to initialize readonly
    public Program()
    {
        x = 50;
    }

    static void Main(string[] args)
    {
        const double PI = 3.14; // constant

        Program obj = new Program();

        Console.WriteLine("Constant PI = " + PI);
        Console.WriteLine("Readonly value = " + obj.x);
    }
}