using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(redPepperEvents.Startup))]
namespace redPepperEvents
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
