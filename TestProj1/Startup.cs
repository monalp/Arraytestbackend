using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestProj1.Startup))]
namespace TestProj1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

        }
    }
}
