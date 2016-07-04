using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestingApplication.Startup))]
namespace TestingApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
