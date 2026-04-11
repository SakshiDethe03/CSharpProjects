<<<<<<< HEAD
using System;

class Program
{
    static int Fib(int n)
    {
        if (n <= 1) return n;
        return Fib(n - 1) + Fib(n - 2);
    }

    static void Main()
    {
        for (int i = 0; i < 5; i++)
            Console.Write(Fib(i) + " ");
    }
=======
using System;

class Program
{
    static int Fib(int n)
    {
        if (n <= 1) return n;
        return Fib(n - 1) + Fib(n - 2);
    }

    static void Main()
    {
        for (int i = 0; i < 5; i++)
            Console.Write(Fib(i) + " ");
    }
>>>>>>> 213993cd588861daa0c5a198eaa329f1cda16642
}