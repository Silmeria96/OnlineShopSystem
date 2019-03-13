using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineShopSystem.UI.Startup))]
namespace OnlineShopSystem.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}
