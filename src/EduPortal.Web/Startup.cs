using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EduPortal.Web.Startup))]
namespace EduPortal.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
