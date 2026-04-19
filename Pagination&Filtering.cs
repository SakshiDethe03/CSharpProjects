app.MapGet("/students", (int page, int size, AppDbContext db) =>
    db.Students.Skip((page - 1) * size).Take(size).ToList());