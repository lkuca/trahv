using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(trahv.Startup))]
namespace trahv
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
