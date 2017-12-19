using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YoureOnBootsTrap.Startup))]
namespace YoureOnBootsTrap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
