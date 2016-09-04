using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContactManager.Startup))]
namespace ContactManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            app.UseGoogleAuthentication(
                clientId: "663441201333-2r4h1d98aqie8v1c5752sla5b8ipal0l.apps.googleusercontent.com",
                clientSecret: "UFsmuIPEHJDfKjdBdoJJ5TJ5");

            app.UseFacebookAuthentication(
                appId: "1229528817093789",
                appSecret: "40b4d45bf263186a24ded681f1e4e420");
        }
    }
}
