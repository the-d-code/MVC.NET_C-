using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_first_tuition.Startup))]
namespace MVC_first_tuition
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
