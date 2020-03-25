using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sam_GameWebsite.Startup))]
namespace Sam_GameWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
