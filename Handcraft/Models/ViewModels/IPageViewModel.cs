using EPiServer.Core;
using Handcraft.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Handcraft.Models.ViewModels
{
    public interface IPageViewModel<out T> where T : SitePageData
    {
        T CurrentPage { get; }
        LayoutModel Layout { get; set; }
        IContent Section { get; set; }
    }
}