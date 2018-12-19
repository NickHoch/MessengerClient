using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MessengerClient.Startup))]
namespace MessengerClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
