using Microsoft.Extensions.Hosting;

class Worker : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            Console.WriteLine("Running...");
            await Task.Delay(5000);
        }
    }
}