using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using Handcraft.Models.Blocks;
using System;
using System.ComponentModel.DataAnnotations;

namespace Handcraft.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "2ca3f4d4-9e52-4828-9272-072eb7ee8995", Description = "")]
    public class StartPage : SitePageData
    {
        [Display(Name = "Main Content Area", GroupName = SystemTabNames.Content, Order = 100)]
        public virtual ContentArea MainContentArea { get; set; }

        [Display(Name = "Carousel Block", GroupName = SystemTabNames.Content, Order = 105)]
        public virtual CarouselBlock Carousel { get; set; }
    }
}