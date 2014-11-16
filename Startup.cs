using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Funwarbook.Startup))]
namespace Funwarbook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
