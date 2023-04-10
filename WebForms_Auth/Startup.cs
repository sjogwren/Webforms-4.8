using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebForms_Auth.Startup))]
namespace WebForms_Auth
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
