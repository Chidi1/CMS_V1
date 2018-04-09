using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CMS_version1.Startup))]
namespace CMS_version1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
