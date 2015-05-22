using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AreaBudgetCalculator.Startup))]
namespace AreaBudgetCalculator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
