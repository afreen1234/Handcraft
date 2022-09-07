using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System;
using System.ComponentModel.DataAnnotations;

namespace Handcraft.Models.Blocks
{
    [ContentType(DisplayName = "YoutubeBlock", GUID = "2a0d9a2d-8e1e-48b0-866e-954fa998d84e", Description = "")]
    public class YoutubeBlock : BlockData
    {
        [Display(Name = "Title", GroupName = SystemTabNames.Content, Order = 600)]
        public virtual string VideoTitle { get; set; }

        [Display(Name = "Description",GroupName = SystemTabNames.Content, Order = 605)]
        [UIHint(UIHint.Textarea)]
        public virtual string Description { get; set; }

        [Display(Name = "Url to Youtube Video", GroupName = SystemTabNames.Content, Order = 610)]
        public virtual Url YoutubeLink { get; set; }

        [Display(Name = "Width", GroupName = SystemTabNames.Content, Order = 615)]
        public virtual int Width { get; set; }

        [Display(Name = "Height", GroupName = SystemTabNames.Content, Order = 620)]
        public virtual int Height { get; set; }

        [Display(Name = "Allow Full Screen", GroupName = SystemTabNames.Content, Order = 625)]
        public virtual bool AllowFullScreen { get; set; }

        [Display(Name = "Auto Play", GroupName = SystemTabNames.Content, Order = 630)]
        public virtual bool AutoPlay { get; set; }

        public override void SetDefaultValues(ContentType contentType)
        {
            this.AllowFullScreen = true;
            this.AutoPlay = false;
            this.Width = 520;
            this.Height = 292;
        }
    }
}