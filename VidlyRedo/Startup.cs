using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyRedo.Startup))]
namespace VidlyRedo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
