using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bank.WebUI.Startup))]
namespace Bank.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
