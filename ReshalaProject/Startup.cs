using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReshalaProject.Startup))]
namespace ReshalaProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
