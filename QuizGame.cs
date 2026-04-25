using System;
using System.Collections.Generic;

class Question
{
    public string Text { get; set; }
    public string[] Options { get; set; }
    public int CorrectAnswer { get; set; }
}

class Program
{
    static List<Question> questions = new List<Question>();
    static int score = 0;

    static void Main()
    {
        questions.Add(new Question { Text = "What is 2+2?", Options = new[] { "3", "4", "5", "6" }, CorrectAnswer = 2 });
        questions.Add(new Question { Text = "Capital of France?", Options = new[] { "London", "Berlin", "Paris", "Rome" }, CorrectAnswer = 3 });
        questions.Add(new Question { Text = "5*5=?", Options = new[] { "20", "25", "30", "35" }, CorrectAnswer = 2 });

        Console.WriteLine("=== Quiz Game ===");
        for (int i = 0; i < questions.Count; i++)
        {
            Console.WriteLine($"\nQ{i + 1}: {questions[i].Text}");
            for (int j = 0; j < questions[i].Options.Length; j++)
                Console.WriteLine($"{j + 1}. {questions[i].Options[j]}");

            Console.Write("Answer: ");
            int ans = int.Parse(Console.ReadLine());
            if (ans == questions[i].CorrectAnswer)
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Wrong!");
            }
        }

        Console.WriteLine($"\nFinal Score: {score}/{questions.Count}");
    }
}