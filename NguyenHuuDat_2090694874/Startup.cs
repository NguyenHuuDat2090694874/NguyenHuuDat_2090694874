using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenHuuDat_2090694874.Startup))]
namespace NguyenHuuDat_2090694874
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
