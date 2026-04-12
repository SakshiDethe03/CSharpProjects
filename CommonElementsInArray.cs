using System;

class Program
{
    static void Main()
    {
        int[] a = {1,2,3};
        int[] b = {2,3,4};

        foreach(int i in a)
        {
            foreach(int j in b)
            {
                if(i == j)
                    Console.Write(i + " ");
            }
        }
    }
}