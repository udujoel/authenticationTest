using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(authenticationTest.Startup))]
namespace authenticationTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
