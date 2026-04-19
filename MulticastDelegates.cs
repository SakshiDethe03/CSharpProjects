using System;

delegate void MyDelegate();

class Program
{
    static void A() => Console.WriteLine("A");
    static void B() => Console.WriteLine("B");

    static void Main()
    {
        MyDelegate d = A;
        d += B;

        d(); // calls both A and B
    }
}