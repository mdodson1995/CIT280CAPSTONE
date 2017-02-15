using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomerRelationsManager.Startup))]
namespace CustomerRelationsManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
