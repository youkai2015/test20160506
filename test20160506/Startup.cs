using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(test20160506.Startup))]
namespace test20160506
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
