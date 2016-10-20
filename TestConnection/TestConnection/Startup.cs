using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestConnection.Startup))]
namespace TestConnection
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
