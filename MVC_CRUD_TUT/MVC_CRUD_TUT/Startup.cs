using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_CRUD_TUT.Startup))]
namespace MVC_CRUD_TUT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
