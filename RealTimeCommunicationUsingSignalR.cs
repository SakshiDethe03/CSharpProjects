using Microsoft.AspNetCore.SignalR;

class ChatHub : Hub
{
    public async Task Send(string msg)
    {
        await Clients.All.SendAsync("Receive", msg);
    }
}