using System;

class Demo
{
    public const int x = 10;
    public readonly int y;

    public Demo()
    {
        y = 20;
    }
}

class Program
{
    static void Main()
    {
        Demo d = new Demo();
        Console.WriteLine(Demo.x);
        Console.WriteLine(d.y);
    }
}