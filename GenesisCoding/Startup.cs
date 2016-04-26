using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GenesisCoding.Startup))]
namespace GenesisCoding
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
