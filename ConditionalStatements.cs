using System;

class Program
{
    static void Main(string[] args)
    {
        int num;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        // if-else
        if (num > 0)
        {
            Console.WriteLine("Positive number");
        }
        else if (num < 0)
        {
            Console.WriteLine("Negative number");
        }
        else
        {
            Console.WriteLine("Zero");
        }

        // switch case
        Console.WriteLine("\nEnter a day number (1-7): ");
        int day = Convert.ToInt32(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;  
            case 7:
                Console.WriteLine("Sunday");
                break;              
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
}