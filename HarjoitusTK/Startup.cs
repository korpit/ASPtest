using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HarjoitusTK.Startup))]
namespace HarjoitusTK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
