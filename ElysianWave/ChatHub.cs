using Microsoft.AspNetCore.SignalR;
namespace ElysianWave
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message, string userId)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message, userId);
        }
    }
}
