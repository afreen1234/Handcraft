using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace Handcraft.Models.Blocks
{
    [ContentType(DisplayName = "HeaderBlock", GUID = "117cf371-57dd-44d4-b8e5-584c3174afc1", Description = "")]
    public class HeaderBlock : BlockData
    {
        [Display(Name = "Header Script", GroupName = SystemTabNames.Content, Order = 600)]
        public virtual XhtmlString HeaderScript { get; set; }
    }
}