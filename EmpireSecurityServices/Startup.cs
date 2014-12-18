using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmpireSecurityServices.Startup))]
namespace EmpireSecurityServices
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
