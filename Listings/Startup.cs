using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Listings.Startup))]
namespace Listings
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
