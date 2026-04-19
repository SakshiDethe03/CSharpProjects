using System;

delegate void MyDelegate();

class Program
{
    static void Main()
    {
        MyDelegate d = delegate ()
        {
            Console.WriteLine("Anonymous Method");
        };

        d();
    }
}