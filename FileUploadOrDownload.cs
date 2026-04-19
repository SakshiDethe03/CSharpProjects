// Upload
app.MapPost("/upload", async (IFormFile file) =>
{
    var path = Path.Combine("uploads", file.FileName);
    using var stream = File.Create(path);
    await file.CopyToAsync(stream);
});

// Download
app.MapGet("/download", (string name) =>
{
    return Results.File($"uploads/{name}");
});