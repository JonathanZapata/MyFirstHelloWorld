using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFistHelloWorld.Startup))]
namespace MyFistHelloWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
