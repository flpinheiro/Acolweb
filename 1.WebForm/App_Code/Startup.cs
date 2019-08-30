using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1.WebForm.Startup))]
namespace _1.WebForm
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
