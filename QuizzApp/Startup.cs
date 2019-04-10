using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuizzApp.Startup))]
namespace QuizzApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
