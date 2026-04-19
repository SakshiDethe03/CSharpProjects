builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = "localhost:6379";
});