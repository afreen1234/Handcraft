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
        [Display(Name = "Meta Data", GroupName = SystemTabNames.Settings, Order = 10)]
        public virtual string MetaData { get; set; }

        [CultureSpecific]
        [Display(Name = "Meta Title", GroupName = SystemTabNames.Settings, Order = 15)]
        public virtual string MetaTitle { get; set; }

        [CultureSpecific]
        [Display(Name = "Meta Description", GroupName = SystemTabNames.Settings, Order = 20)]
        public virtual string MetaDescription { get; set; }

        [Display(GroupName = SystemTabNames.Settings, Order = 25)]
        [CultureSpecific]
        public virtual bool HideSiteHeader { get; set; }

        [Display(GroupName = SystemTabNames.Settings, Order = 30)]
        [CultureSpecific]
        public virtual bool HideSiteFooter { get; set; }
    }
}