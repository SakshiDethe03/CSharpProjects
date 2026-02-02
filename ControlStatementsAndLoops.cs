using System;

namespace ControlStatementsAndLoops
{
    class ControlStatementsAndLoops
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("--Menu--");
                Console.WriteLine("1. Multiplication Table using for loop");
                Console.WriteLine("2. Multiplication Table using while loop");
                Console.WriteLine("3. Odd or Even using if-else");
                Console.WriteLine("4. Odd or Even using switch-case");
                Console.Write("5. Exit\n");
                Console.Write("Enter your choice (1-5): ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter a number: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine($"{num1} x {i} = {num1 * i}");
                        }
                        break;

                    case 2:
                        Console.Write("Enter a number: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        int j = 1;
                        while(j <= 10)
                        {
                            Console.WriteLine($"{num2} x {j} = {num2 * j}");
                            j++;
                        }
                        break;

                    case 3:
                        Console.Write("Enter a number: ");
                        int n1 = Convert.ToInt32(Console.ReadLine());

                        if (n1 % 2 == 0)
                        {
                            Console.WriteLine($"{n1} is Even.");
                        }
                        else
                        {
                            Console.WriteLine($"{n1} is Odd.");
                        }
                        break;

                    case 4:
                        Console.Write("Enter a number: ");
                        int n2 = Convert.ToInt32(Console.ReadLine());

                        switch( n2 % 2)
                        {
                            case 0:
                                Console.WriteLine($"{n2} is Even.");
                                break;

                            case 1:
                                Console.WriteLine($"{n2} is Odd.");
                                break;    
                        }
                        break;

                    case 5:
                        Console.WriteLine("Exiting the program.");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice. Please try again.");
                        break;            
                }
                while(choice != 5);

                Console.WriteLine("\nEnd of the program.");
            }       
        }   
    }
}