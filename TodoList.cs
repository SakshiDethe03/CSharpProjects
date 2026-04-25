using System;
using System.Collections.Generic;

class TaskItem
{
    public string Title { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime DueDate { get; set; }
}

class Program
{
    static List<TaskItem> tasks = new List<TaskItem>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== To-Do List ===");
            Console.WriteLine("1.Add Task 2.View Tasks 3.Mark Complete 4.Delete 5.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Task: ");
                    string title = Console.ReadLine();
                    Console.Write("Due Date (yyyy-MM-dd): ");
                    DateTime due = DateTime.Parse(Console.ReadLine());
                    tasks.Add(new TaskItem { Title = title, DueDate = due });
                    Console.WriteLine("Task added!");
                    break;

                case 2:
                    foreach (var t in tasks)
                        Console.WriteLine($"[{(t.IsCompleted ? "X" : " ")}] {t.Title} - Due: {t.DueDate:yyyy-MM-dd}");
                    break;

                case 3:
                    Console.Write("Task # to complete: ");
                    int idx = int.Parse(Console.ReadLine()) - 1;
                    if (idx >= 0 && idx < tasks.Count)
                        tasks[idx].IsCompleted = true;
                    break;

                case 4:
                    Console.Write("Task # to delete: ");
                    idx = int.Parse(Console.ReadLine()) - 1;
                    if (idx >= 0 && idx < tasks.Count)
                        tasks.RemoveAt(idx);
                    break;

                case 5:
                    return;
            }
        }
    }
}