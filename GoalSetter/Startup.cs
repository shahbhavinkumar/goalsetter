using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoalSetter.Startup))]
namespace GoalSetter
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
