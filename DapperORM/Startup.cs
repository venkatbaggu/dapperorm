using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DapperORM.Startup))]
namespace DapperORM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
