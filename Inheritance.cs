using System;

class Parent
{
    public void Show()
    {
        Console.WriteLine("Parent Class");
    }
}

class Child : Parent
{
}

class Program
{
    static void Main()
    {
        Child c = new Child();
        c.Show();
    }
}