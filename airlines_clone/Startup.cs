using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(airlines_clone.Startup))]
namespace airlines_clone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
