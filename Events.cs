using System;

class Publisher
{
    public event Action OnNotify;

    public void Notify()
    {
        OnNotify?.Invoke();
    }
}

class Program
{
    static void Main()
    {
        Publisher p = new Publisher();

        p.OnNotify += () => Console.WriteLine("Event Triggered");

        p.Notify();
    }
}