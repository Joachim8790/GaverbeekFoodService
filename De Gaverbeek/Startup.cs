using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(De_Gaverbeek.Startup))]
namespace De_Gaverbeek
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
