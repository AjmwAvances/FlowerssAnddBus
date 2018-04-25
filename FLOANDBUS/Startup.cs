using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FLOANDBUS.Startup))]
namespace FLOANDBUS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
