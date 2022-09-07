using EPiServer.Web.Mvc;
using Handcraft.Business;
using Handcraft.Models.Pages;
using Handcraft.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Handcraft.Controllers
{
    public abstract class PageControllerBase<T>  : PageController<T>, IModifyLayout
        where T : SitePageData
    {
        // GET: PageControllerBase
        public ActionResult Index()
        {
            return View();
        }

        public virtual void ModifyLayout(LayoutModel layoutModel)
        {
            var page = PageContext.Page as SitePageData;
            if (page != null)
            {
                layoutModel.HideHeader = page.HideSiteHeader;
                layoutModel.HideFooter = page.HideSiteFooter;
            }
        }
    }
}