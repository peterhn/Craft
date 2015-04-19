using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutismAppJam.Startup))]
namespace AutismAppJam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
