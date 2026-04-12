using System;

interface IAnimal
{
    void Sound();
}

class Dog : IAnimal
{
    public void Sound()
    {
        Console.WriteLine("Bark");
    }
}

class Program
{
    static void Main()
    {
        IAnimal a = new Dog();
        a.Sound();
    }
}