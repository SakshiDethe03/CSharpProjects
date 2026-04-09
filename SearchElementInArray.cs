using System;

class Program
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40 };
        int key = 30;
        bool found = false;

        foreach (int i in arr)
        {
            if (i == key)
            {
                found = true;
                break;
            }
        }

        Console.WriteLine(found ? "Element Found" : "Not Found");
    }
}