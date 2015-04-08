using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PizzaProjectAlt.Startup))]
namespace PizzaProjectAlt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
