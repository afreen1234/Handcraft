using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;
using Handcraft.Models.Blocks;
using System;
using System.ComponentModel.DataAnnotations;

namespace Handcraft.Models.Pages
{
    [ContentType(DisplayName = "AboutPage", GUID = "0fb21ae5-4429-4c71-85ca-4bdea28f9bd5", Description = "")]
    public class AboutPage : SitePageData
    {
        [Display(Name = "Image", GroupName = SystemTabNames.Content, Order = 200)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [Display(Name = "Description", GroupName = SystemTabNames.Content, Order = 210)]
        [UIHint(UIHint.Textarea)]
        public virtual string Description { get; set; }

        [Display(Name = "About Content Area", GroupName = SystemTabNames.Content, Order = 215)]
        public virtual ContentArea AboutContentArea { get; set; }

    }
}