using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1911066528_BuiXuanHai_Bigschool.Startup))]
namespace _1911066528_BuiXuanHai_Bigschool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
