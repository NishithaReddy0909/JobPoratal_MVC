using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JobPoratal_MVC.Startup))]
namespace JobPoratal_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
