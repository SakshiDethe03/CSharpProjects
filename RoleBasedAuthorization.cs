app.MapGet("/admin", () => "Admin Only")
   .RequireAuthorization(policy => policy.RequireRole("Admin"));