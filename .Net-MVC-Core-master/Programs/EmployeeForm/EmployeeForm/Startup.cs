using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmployeeForm.Startup))]
namespace EmployeeForm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
