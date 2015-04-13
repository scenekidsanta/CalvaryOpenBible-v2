using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CalvaryOpebBibleWebsite.Startup))]
namespace CalvaryOpebBibleWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
