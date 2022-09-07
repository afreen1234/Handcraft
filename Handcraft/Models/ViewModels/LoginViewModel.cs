using Handcraft.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Handcraft.Models.ViewModels
{
    public class LoginViewModel : PageViewModel<LoginPage>
    {
        public LoginFormPostbackData LoginPostbackData { get; set; } = new LoginFormPostbackData();
        public LoginViewModel(LoginPage currentPage)
            : base(currentPage)
        {
        }
        public string Message { get; set; }
    }
    public class LoginFormPostbackData
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }
    }
}