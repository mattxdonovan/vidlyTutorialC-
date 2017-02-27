using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vidlyTutorial.Startup))]
namespace vidlyTutorial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
