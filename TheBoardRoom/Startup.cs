using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheBoardRoom.Startup))]
namespace TheBoardRoom
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
