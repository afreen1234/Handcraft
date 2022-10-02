using EPiServer.Cms.UI.AspNetIdentity;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using System;
using System.Linq;
using System.Web;

namespace Handcraft.Commerce.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class IdentityInitialization : IConfigurableModule
    {
        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            context.Services.AddTransient<IOwinContext>(locator => HttpContext.Current.GetOwinContext());
            context.Services.AddTransient<ApplicationUserManager<ApplicationUser>>(locator => locator.GetInstance<IOwinContext>().GetUserManager<ApplicationUserManager<ApplicationUser>>());
            context.Services.AddTransient<IAuthenticationManager>(locator => locator.GetInstance<IOwinContext>().Authentication);
        }

        public void Initialize(InitializationEngine context)
        {
            //Add initialization logic, this method is called once after CMS has been initialized
        }

        public void Uninitialize(InitializationEngine context)
        {
            //Add uninitialization logic
        }
    }
}