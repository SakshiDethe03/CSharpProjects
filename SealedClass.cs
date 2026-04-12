using System;

sealed class Demo
{
    public void Show()
    {
        Console.WriteLine("Sealed Class");
    }
}

class Program
{
    static void Main()
    {
        Demo d = new Demo();
        d.Show();
    }
}