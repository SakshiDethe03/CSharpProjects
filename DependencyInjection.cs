using Microsoft.Extensions.DependencyInjection;

interface IService { void Run(); }

class Service : IService
{
    public void Run() => Console.WriteLine("DI Working");
}

var services = new ServiceCollection();
services.AddTransient<IService, Service>();

var provider = services.BuildServiceProvider();
provider.GetService<IService>().Run();