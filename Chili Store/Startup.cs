using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Chili_Store.Startup))]
namespace Chili_Store
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
