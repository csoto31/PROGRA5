using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrograAvanzada.Northwind.Startup))]
namespace PrograAvanzada.Northwind
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
