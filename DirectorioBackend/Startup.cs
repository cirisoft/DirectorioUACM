using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DirectorioBackend.Startup))]
namespace DirectorioBackend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
