using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeGaverbeekProject.Startup))]
namespace DeGaverbeekProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
