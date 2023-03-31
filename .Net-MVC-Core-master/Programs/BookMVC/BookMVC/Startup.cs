using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookMVC.Startup))]
namespace BookMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
