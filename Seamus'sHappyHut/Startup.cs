using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Seamus_sHappyHut.Startup))]
namespace Seamus_sHappyHut
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
