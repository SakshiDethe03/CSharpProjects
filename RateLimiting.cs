builder.Services.AddRateLimiter(_ =>
{
    _.AddFixedWindowLimiter("limit", opt =>
    {
        opt.PermitLimit = 5;
        opt.Window = TimeSpan.FromSeconds(10);
    });
});

app.UseRateLimiter();