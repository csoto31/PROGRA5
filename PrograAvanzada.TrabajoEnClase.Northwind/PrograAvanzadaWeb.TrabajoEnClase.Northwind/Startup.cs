using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrograAvanzadaWeb.TrabajoEnClase.Northwind.Startup))]
namespace PrograAvanzadaWeb.TrabajoEnClase.Northwind
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
