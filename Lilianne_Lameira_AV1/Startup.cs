using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lilianne_Lameira_AV1.Startup))]
namespace Lilianne_Lameira_AV1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
