using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalRExample.Hubs
{
    // All signalr names (hub name, function names) will be processed as pascal-case
    // However, we can also override it by using attributes as shown below
    [HubName("echo")]
    public class Echo : Hub
    {
        // our signalr server
        // only public functions can be accessed by clients
        [HubMethodName("say")]
        public void Say(string message)
        {
            // call back for client (calling a function defined in javascript from server side)
            Clients.All.replied($"{message}");
        }
    }
}