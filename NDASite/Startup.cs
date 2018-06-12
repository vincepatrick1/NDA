using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NDASite.Startup))]
namespace NDASite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
