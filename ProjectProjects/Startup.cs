using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectProjects.Startup))]
namespace ProjectProjects
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
