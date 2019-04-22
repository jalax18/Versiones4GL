using Backend.Versiones4GL.Models;
using Microsoft.Owin;
using Owin;
using System.Web.Services.Description;

[assembly: OwinStartupAttribute(typeof(Backend.Versiones4GL.Startup))]
namespace Backend.Versiones4GL
{

  

    public partial class Startup
    {
       
        public void Configuration(IAppBuilder app)
        {
          
            ConfigureAuth(app);
        }
    }
}
