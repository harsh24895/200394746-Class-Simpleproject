using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_200394746_Class_Simplepro.Startup))]
namespace _200394746_Class_Simplepro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
