using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace Handcraft.Models.Media
{
    [ContentType(DisplayName = "ImageFile", GUID = "ad54073e-14ef-4b1e-a82a-d7912b0502a1", Description = "")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,ico,gif,bmp,png")]
    public class ImageFile : ImageData
    {
        public virtual string Copyright { get; set; }
    }
}