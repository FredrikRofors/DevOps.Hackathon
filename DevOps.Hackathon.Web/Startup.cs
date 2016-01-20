using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevOps.Hackathon.Web.Startup))]
namespace DevOps.Hackathon.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
