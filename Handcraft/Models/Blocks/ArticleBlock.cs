using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System;
using System.ComponentModel.DataAnnotations;

namespace Handcraft.Models.Blocks
{
    [ContentType(DisplayName = "ArticleBlock", GUID = "3a0893df-593b-4f15-9d5a-5b7bb3bff7d5", Description = "")]
    public class ArticleBlock : BaseBlock
    {
        [Display(Name = "Title", GroupName = SystemTabNames.Content, Order = 200)]
        public virtual string Title { get; set; }

        [Display(Name = "Image", GroupName = SystemTabNames.Content, Order = 205)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [Display(Name = "Description", GroupName = SystemTabNames.Content, Order = 210)]
        [UIHint(UIHint.Textarea)]
        public virtual string Description { get; set; }
    }
}