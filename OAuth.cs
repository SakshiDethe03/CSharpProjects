builder.Services.AddAuthentication()
    .AddGoogle(opt =>
    {
        opt.ClientId = "...";
        opt.ClientSecret = "...";
    });