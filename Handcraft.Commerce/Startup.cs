using EPiServer.Cms.UI.AspNetIdentity;
using EPiServer.ServiceLocation;
using Mediachase.Data.Provider;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Handcraft.Commerce
{
    public class Startup
    {
        private readonly IConnectionStringHandler _connectionStringHandler;
        string loginPath = "/util/login.aspx";

        public Startup() : this(ServiceLocator.Current.GetInstance<IConnectionStringHandler>())
        {
            // Parameterless constructor required by OWIN.
        }

        public Startup(IConnectionStringHandler connectionStringHandler)
        {
            _connectionStringHandler = connectionStringHandler;
        }

        public void Configuration(IAppBuilder app)
        {
            app.AddCmsAspNetIdentity<ApplicationUser>(new ApplicationOptions
            {
                ConnectionStringName = _connectionStringHandler.Commerce.Name
            });

            // Enable the application to use a cookie to store information for the signed in user
            // and to use a cookie to temporarily store information about a user logging in with a third party login provider.
            // Configure the sign in cookie.
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Login"),
                Provider = new CookieAuthenticationProvider
                {
                    // Enables the application to validate the security stamp when the user logs in.
                    // This is a security feature which is used when you change a password or add an external login to your account.  
                    OnValidateIdentity = SecurityStampValidator.OnValidateIdentity<ApplicationUserManager<ApplicationUser>, ApplicationUser>(
                        validateInterval: TimeSpan.FromMinutes(30),
                        regenerateIdentity: (manager, user) => manager.GenerateUserIdentityAsync(user)),
                    OnApplyRedirect = context => context.Response.Redirect(context.RedirectUri),
                    //OnResponseSignOut = context => context.Response.Redirect(UrlResolver.Current.GetUrl(ContentReference.StartPage))
                }
            });
        }
    }
}