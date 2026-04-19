using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var students = new[] {
            new { Id = 1, Name = "A" },
            new { Id = 2, Name = "B" }
        };

        var marks = new[] {
            new { Id = 1, Score = 90 },
            new { Id = 2, Score = 80 }
        };

        var result = students.Join(
            marks,
            s => s.Id,
            m => m.Id,
            (s, m) => new { s.Name, m.Score });

        foreach (var r in result)
            Console.WriteLine(r.Name + " " + r.Score);
    }
}