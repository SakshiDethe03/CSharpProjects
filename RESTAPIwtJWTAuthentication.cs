builder.Services.AddAuthentication("Bearer")
    .AddJwtBearer();

app.UseAuthentication();
app.UseAuthorization();

app.MapGet("/secure", () => "Protected")
   .RequireAuthorization();