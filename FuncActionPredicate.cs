using System;

class Program
{
    static void Main()
    {
        Func<int, int, int> add = (a, b) => a + b;
        Action<string> print = msg => Console.WriteLine(msg);
        Predicate<int> isEven = x => x % 2 == 0;

        Console.WriteLine(add(2, 3));
        print("Hello");
        Console.WriteLine(isEven(4));
    }
}