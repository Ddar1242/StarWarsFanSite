using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StarWarsFanSite.Startup))]
namespace StarWarsFanSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
