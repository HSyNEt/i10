using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(i10.Startup))]
namespace i10
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
