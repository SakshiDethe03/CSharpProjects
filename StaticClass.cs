using System;

static class Utility
{
    public static void Show()
    {
        Console.WriteLine("Static Class Method");
    }
}

class Program
{
    static void Main()
    {
        Utility.Show();
    }
}