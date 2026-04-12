using System;

// S - Single Responsibility
class Report
{
    public void Generate()
    {
        Console.WriteLine("Report Generated");
    }
}

// O - Open/Closed
class Logger
{
    public virtual void Log()
    {
        Console.WriteLine("Log");
    }
}

class FileLogger : Logger
{
    public override void Log()
    {
        Console.WriteLine("File Log");
    }
}