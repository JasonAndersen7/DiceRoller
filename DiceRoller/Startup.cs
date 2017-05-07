using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DiceRoller.Startup))]
namespace DiceRoller
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
