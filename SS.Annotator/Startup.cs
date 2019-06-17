using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SS.Annotator.Startup))]
namespace SS.Annotator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
