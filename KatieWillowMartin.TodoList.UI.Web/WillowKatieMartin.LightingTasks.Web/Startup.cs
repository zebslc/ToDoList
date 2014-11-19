using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WillowKatieMartin.LightingTasks.Web.Startup))]
namespace WillowKatieMartin.LightingTasks.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
