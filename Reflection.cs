using System;

class Demo
{
    public void Show() { }
}

class Program
{
    static void Main()
    {
        Type t = typeof(Demo);

        foreach (var m in t.GetMethods())
            Console.WriteLine(m.Name);
    }
}