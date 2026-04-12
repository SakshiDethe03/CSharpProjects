using System;

abstract class Animal
{
    public abstract void Sound();
}

interface IAnimal
{
    void Move();
}

class Dog : Animal, IAnimal
{
    public override void Sound()
    {
        Console.WriteLine("Bark");
    }

    public void Move()
    {
        Console.WriteLine("Run");
    }
}

class Program
{
    static void Main()
    {
        Dog d = new Dog();
        d.Sound();
        d.Move();
    }
}