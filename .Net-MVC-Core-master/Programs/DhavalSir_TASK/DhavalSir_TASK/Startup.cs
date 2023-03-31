using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DhavalSir_TASK.Startup))]
namespace DhavalSir_TASK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
