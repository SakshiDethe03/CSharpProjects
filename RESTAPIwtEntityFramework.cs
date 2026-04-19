app.MapGet("/students", (AppDbContext db) =>
    db.Students.ToList());