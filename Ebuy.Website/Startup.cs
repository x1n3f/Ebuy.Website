using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ebuy.Website.Startup))]
namespace Ebuy.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
