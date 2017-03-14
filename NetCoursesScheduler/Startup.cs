using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NetCoursesScheduler.Startup))]
namespace NetCoursesScheduler
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
