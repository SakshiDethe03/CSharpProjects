using System;

delegate void MyDelegate();

class Program
{
    static void Show()
    {
        Console.WriteLine("Delegate Called");
    }

    static void Main()
    {
        MyDelegate d = Show;
        d();
    }
}