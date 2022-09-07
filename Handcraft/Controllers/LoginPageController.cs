using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using Handcraft.Models.Pages;
using Handcraft.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Security;

namespace Handcraft.Controllers
{
    public class LoginPageController : PageController<LoginPage>
    {
        public ActionResult Index(LoginPage currentPage, [FromUri] string ReturnUrl)
        {
            var model = new LoginViewModel(currentPage);
            model.LoginPostbackData.ReturnUrl = ReturnUrl;
            return View("~/Views/LoginPage/_Login.cshtml",model);
        }

        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Post(LoginPage currentPage, [FromBody] LoginFormPostbackData LoginPostbackData)
        {
            var model = new LoginViewModel(currentPage);
            var isValid = Membership.Provider.ValidateUser(LoginPostbackData.Username, LoginPostbackData.Password);
            if (isValid)
            {
                var redirectUrl = GetRedirectUrl(LoginPostbackData.ReturnUrl);
                FormsAuthentication.SetAuthCookie(LoginPostbackData.Username, LoginPostbackData.RememberMe);
                return Redirect(redirectUrl); //Important to redirect after login to be sure cookies etc are set.
            }
            model.Message = "Wrong credentials, try again";
            return View("~/Views/LoginPage/_Login.cshtml", model);
        }

        public string GetRedirectUrl(string returnUrl)
        {
            if (!string.IsNullOrEmpty(returnUrl))
            {
                return returnUrl;
            }
            return FormsAuthentication.DefaultUrl;
        }
    }
}