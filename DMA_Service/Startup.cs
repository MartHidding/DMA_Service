using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(DMA_Service.Startup))]

namespace DMA_Service
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}