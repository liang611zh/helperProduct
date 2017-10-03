using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(helperProduct.Startup))]
namespace helperProduct
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
