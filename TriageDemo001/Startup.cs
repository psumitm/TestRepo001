using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TriageDemo001.Startup))]
namespace TriageDemo001
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
