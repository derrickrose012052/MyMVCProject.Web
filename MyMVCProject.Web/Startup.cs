using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMVCProject.Web.Startup))]
namespace MyMVCProject.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
