using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AplicacaoTeste.Startup))]
namespace AplicacaoTeste
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
