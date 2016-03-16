using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WeddApp.Startup))]
namespace WeddApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
