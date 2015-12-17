using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sandbox461.Startup))]
namespace Sandbox461
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
