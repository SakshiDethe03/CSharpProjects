using System;

class Program
{
    static void Main(string[] args)
    {
        // Implicit casting
        int num = 10;
        double d = num;  

        Console.WriteLine("Implicit Casting (int to double): " + d);

        // Explicit casting
        double x = 9.78;
        int y = (int)x;

        Console.WriteLine("Explicit Casting (double to int): " + y);

        // Using Convert
        string str = "123";
        int z = Convert.ToInt32(str);

        Console.WriteLine("String to int using Convert: " + z);
    }
}