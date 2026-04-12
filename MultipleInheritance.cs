using System;

interface A
{
    void ShowA();
}

interface B
{
    void ShowB();
}

class Demo : A, B
{
    public void ShowA() => Console.WriteLine("A");
    public void ShowB() => Console.WriteLine("B");
}

class Program
{
    static void Main()
    {
        Demo d = new Demo();
        d.ShowA();
        d.ShowB();
    }
}