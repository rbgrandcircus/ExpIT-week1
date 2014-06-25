using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(github_test.Startup))]
namespace github_test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
