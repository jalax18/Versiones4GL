using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Versiones4GL.Backend.Startup))]
namespace Versiones4GL.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
