using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalRExample.Startup))]

namespace SignalRExample
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Do not forget to map your signalr
            app.MapSignalR();
        }
    }
}
