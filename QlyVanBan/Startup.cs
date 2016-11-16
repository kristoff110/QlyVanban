using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QlyVanBan.Startup))]
namespace QlyVanBan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
