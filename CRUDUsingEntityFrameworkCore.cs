// Requires EF Core setup (DbContext, packages)
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        using (var db = new AppDbContext())
        {
            db.Students.Add(new Student { Name = "A" });
            db.SaveChanges();

            var list = db.Students.ToList();
        }
    }
}