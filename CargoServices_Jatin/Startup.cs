using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CargoServices_Jatin.Startup))]
namespace CargoServices_Jatin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
