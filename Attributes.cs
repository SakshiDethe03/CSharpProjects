using System;

[Obsolete("Old method")]
class Demo
{
    public void Show() { }
}

class Program
{
    static void Main()
    {
        Demo d = new Demo();
        d.Show();
    }
}