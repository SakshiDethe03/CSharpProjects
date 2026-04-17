using System;

class Program
{
    static void Main()
    {
        try
        {
            int x = 10 / 0;
        }
        catch
        {
            Console.WriteLine("Exception Caught");
        }
        finally
        {
            Console.WriteLine("Finally Block Executed");
        }
    }
}