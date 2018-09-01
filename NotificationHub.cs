using Microsoft.AspNetCore.SignalR;

namespace mugh_demo
{
    public class NotificationHub: Hub
    {
        public void BroadcastMessage(string message)
        {
            Clients.All.SendAsync("clientbroadcastMessage", message);
        }
    }
}