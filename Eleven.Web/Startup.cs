using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Eleven.Web.Startup))]
namespace Eleven.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
