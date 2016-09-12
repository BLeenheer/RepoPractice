using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RepoPracticeSite.Startup))]
namespace RepoPracticeSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
