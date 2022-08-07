using EPiServer.Cms.Shell.UI.ObjectEditing.EditorDescriptors;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Handcraft.Models.Blocks
{
    [ContentType(DisplayName = "CarouselBlock", GUID = "5555acad-b79f-4574-9527-e2c273f7a926", Description = "")]
    public class CarouselBlock : BaseBlock
    {
        [Display(Name = "List of Images", GroupName = SystemTabNames.Content, Order = 400)]
        [AllowedTypes(typeof(SliderItem))]
        public virtual ContentArea ImageItems { get; set; }

    }
}