using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IT_LAB3.Startup))]
namespace IT_LAB3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
