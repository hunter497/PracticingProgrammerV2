using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Practicing_Programmer.Startup))]
namespace Practicing_Programmer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
