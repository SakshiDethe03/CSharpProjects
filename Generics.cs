using System;

class Box<T>
{
    public T Value;
}

class Program
{
    static void Main()
    {
        Box<int> b = new Box<int>();
        b.Value = 100;

        Console.WriteLine(b.Value);
    }
}