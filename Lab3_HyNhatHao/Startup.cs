using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab3_HyNhatHao.Startup))]
namespace Lab3_HyNhatHao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
