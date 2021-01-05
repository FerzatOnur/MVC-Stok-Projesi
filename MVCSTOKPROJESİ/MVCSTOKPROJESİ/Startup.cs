using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCSTOKPROJESİ.Startup))]
namespace MVCSTOKPROJESİ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
