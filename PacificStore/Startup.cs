using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PacificStore.Startup))]
namespace PacificStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
