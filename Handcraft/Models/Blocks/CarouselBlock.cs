using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Handcraft.Models.Blocks
{
    [ContentType(DisplayName = "CarouselBlock", GUID = "b8202356-ef03-4dc9-813f-78fa3dc00265", Description = "")]
    public class CarouselBlock : BaseBlock
    {
        [AllowedTypes(typeof(ImageData))]
        [Display(Name ="List of Images", GroupName = SystemTabNames.Content, Order = 500)]
        public virtual IList<ContentReference> Images { get; set; }
    }
}