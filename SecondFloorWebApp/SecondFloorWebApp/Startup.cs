using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecondFloorWebApp.Startup))]
namespace SecondFloorWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
