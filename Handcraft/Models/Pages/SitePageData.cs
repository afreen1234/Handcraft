using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.ComponentModel.DataAnnotations;

namespace Handcraft.Models.Pages
{
    [ContentType(DisplayName = "SitePageData", GUID = "2a5ca410-97de-4d34-a157-e2b02fa05546", Description = "")]
    public class SitePageData : PageData
    {
        [CultureSpecific]
        [Display(Name = "MetaData", GroupName = Global.GroupNames.SiteSettings, Order = 10)]
        public virtual string MetaData { get; set; }

        [CultureSpecific]
        [Display(Name = "Metatitle", GroupName = Global.GroupNames.SiteSettings, Order = 15)]
        public virtual string Metatitle { get; set; }
    }
}