using System;

static class Ext
{
    public static int Square(this int x)
    {
        return x * x;
    }
}

class Program
{
    static void Main()
    {
        int num = 5;
        Console.WriteLine(num.Square());
    }
}