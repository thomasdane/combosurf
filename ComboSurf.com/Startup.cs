using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ComboSurf.com.Startup))]
namespace ComboSurf.com
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
