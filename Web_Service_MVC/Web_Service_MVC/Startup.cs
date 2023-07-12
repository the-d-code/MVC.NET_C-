using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_Service_MVC.Startup))]
namespace Web_Service_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
