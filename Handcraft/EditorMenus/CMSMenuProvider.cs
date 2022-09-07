using EPiServer;
using EPiServer.Security;
using EPiServer.Shell.Modules;
using EPiServer.Shell.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Handcraft.EditorMenus
{
    [MenuProvider]
    public class CMSMenuProvider : IMenuProvider
    {
        public IEnumerable<MenuItem> GetMenuItems()
        {
            var menuItems = new List<MenuItem>();
            menuItems.Add(new UrlMenuItem("SiteSettings",
                MenuPaths.Global + "/cms" + "/cmsMenuItem",
                UriSupport.ResolveUrlFromUIAsRelativeOrAbsolute("SiteSettings/Index"))
            {
                SortIndex = SortIndex.First + 25,
                IsAvailable = (request) => PrincipalInfo.HasAdminAccess
            });

            return menuItems;
        }
    }
}