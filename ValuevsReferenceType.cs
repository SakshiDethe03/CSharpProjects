using System;

class Program
{
    static void Main()
    {
        int a = 10;
        int b = a;
        b++;

        Console.WriteLine(a); // value type

        int[] arr1 = {1,2};
        int[] arr2 = arr1;
        arr2[0] = 100;

        Console.WriteLine(arr1[0]); // reference type
    }
}