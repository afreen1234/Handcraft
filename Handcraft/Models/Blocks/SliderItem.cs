using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System;
using System.ComponentModel.DataAnnotations;

namespace Handcraft.Models.Blocks
{
    [ContentType(DisplayName = "SliderItem", GUID = "0694062f-98a4-402d-a514-e8d41c0e7d8c", Description = "")]
    [AvailableContentTypes(Availability.Specific, IncludeOn = new[] { typeof(CarouselBlock) })]
    public class SliderItem : BaseBlock
    {
        [Display(Name = "Image", GroupName = SystemTabNames.Content, Order = 500)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Item { get; set; }

        [Display(Name = "Image Url", GroupName = SystemTabNames.Content, Order = 505)]
        public virtual Url ImageUrl { get; set; }

        [Display(Name = "Alt Message", GroupName = SystemTabNames.Content, Order = 510)]
        public virtual string AltText { get; set; }

    }
}