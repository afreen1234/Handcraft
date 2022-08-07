using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web;
using System;
using System.ComponentModel.DataAnnotations;

namespace Handcraft.Models.Media
{
    [ContentType(DisplayName = "VideoFile", GUID = "8a112bc6-bb3a-459f-b4c8-e97dcd80c238", Description = "")]
    [MediaDescriptor(ExtensionString = "flv,mp4,webm")]
    public class VideoFile : VideoData
    {
        public virtual string Copyright { get; set; }

        [UIHint(UIHint.Image)]
        public virtual ContentReference PreviewImage { get; set; }
    }
}