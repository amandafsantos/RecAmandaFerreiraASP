using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RecAmandaFerreiraASP.Startup))]
namespace RecAmandaFerreiraASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
