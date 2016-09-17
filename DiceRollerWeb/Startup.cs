using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DiceRollerWeb.Startup))]
namespace DiceRollerWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
