using System;

class Program
{
    static void Test(ref int a, out int b)
    {
        a = a + 10;
        b = 20;
    }

    static void Main()
    {
        int x = 5, y;

        Test(ref x, out y);

        Console.WriteLine(x); // 15
        Console.WriteLine(y); // 20
    }
}