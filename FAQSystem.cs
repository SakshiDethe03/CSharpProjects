using System;
using System.Collections.Generic;

class Question
{
    public string Text { get; set; }
    public string Answer { get; set; }
}

class Program
{
    static List<Question> faqs = new List<Question>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== FAQ System ===");
            Console.WriteLine("1.Add FAQ 2.View FAQs 3.Search 4.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Question: ");
                    string q = Console.ReadLine();
                    Console.Write("Answer: ");
                    string a = Console.ReadLine();
                    faqs.Add(new Question { Text = q, Answer = a });
                    Console.WriteLine("FAQ added!");
                    break;

                case 2:
                    foreach (var f in faqs)
                    {
                        Console.WriteLine($"Q: {f.Text}");
                        Console.WriteLine($"A: {f.Answer}");
                    }
                    break;

                case 3:
                    Console.Write("Search: ");
                    string search = Console.ReadLine();
                    foreach (var f in faqs.FindAll(x => x.Text.Contains(search) || x.Answer.Contains(search)))
                    {
                        Console.WriteLine($"Q: {f.Text}");
                        Console.WriteLine($"A: {f.Answer}");
                    }
                    break;

                case 4:
                    return;
            }
        }
    }
}