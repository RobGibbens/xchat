using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace XChat
{
    [HubName("chathub")]
    public class chathub : Hub
    {
        public void sendMessage(string message)
        {
            Clients.All.addMessage(message);
        }
    }
}