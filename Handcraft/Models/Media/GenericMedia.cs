using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace Handcraft.Models.Media
{
    [ContentType(DisplayName = "GenericMedia", GUID = "7493b51b-6bac-4342-bcaf-ad0d824c24c4", Description = "")]
    public class GenericMedia : MediaData
    {
        public virtual String Description { get; set; }
    }
}