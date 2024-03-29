﻿using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using Handcraft.Models.Pages;
using Handcraft.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Handcraft.Controllers
{
    public class AboutPageController : PageController<AboutPage>
    {
        public ActionResult Index(AboutPage currentPage)
        {
            var model = PageViewModel.Create(currentPage);
            return View(model);
        }
    }
}