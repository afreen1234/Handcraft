using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Web;
using System;
using System.ComponentModel.DataAnnotations;

namespace Handcraft.Models.Blocks
{
    [ContentType(DisplayName = "LogoBlock", GUID = "6bca23ae-b2b5-405b-a418-4bdd1c70b32b", Description = "")]
    public class LogoBlock : BlockData
    {
        [DefaultDragAndDropTarget]
        [UIHint(UIHint.Image)]
        public virtual Url Url
        {
            get
            {
                var url = this.GetPropertyValue(b => b.Url);

                return url == null || url.IsEmpty() ? new Url("/Static/gfx/icons8-disney-logo-48.png") : url;
            }
            set
            {
                this.SetPropertyValue(b => b.Url, value);
            }
        }

        [CultureSpecific]
        public virtual string Title { get; set; }
    }
}