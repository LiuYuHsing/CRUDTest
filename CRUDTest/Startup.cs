using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRUDTest.Startup))]
namespace CRUDTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
