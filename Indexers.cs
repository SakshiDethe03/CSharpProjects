using System;

class Sample
{
    private int[] arr = { 10, 20, 30 };

    public int this[int index]
    {
        get { return arr[index]; }
        set { arr[index] = value; }
    }
}

class Program
{
    static void Main()
    {
        Sample s = new Sample();
        Console.WriteLine(s[1]);
    }
}