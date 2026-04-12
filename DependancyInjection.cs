using System;

interface IMessage
{
    void Send();
}

class Email : IMessage
{
    public void Send()
    {
        Console.WriteLine("Email sent");
    }
}

class Service
{
    private IMessage _msg;

    public Service(IMessage msg)
    {
        _msg = msg;
    }

    public void Run()
    {
        _msg.Send();
    }
}

class Program
{
    static void Main()
    {
        Service s = new Service(new Email());
        s.Run();
    }
}