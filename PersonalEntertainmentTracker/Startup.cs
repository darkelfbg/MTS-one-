using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonalEntertainmentTracker.Startup))]
namespace PersonalEntertainmentTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
