using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.SpecializedProperties;
using Handcraft.Models.Blocks;

namespace Handcraft.Models.ViewModels
{
    public class LayoutModel
    {
        public LogoBlock Logo { get; set; }
        public CarouselBlock Carousel { get; set; }
        public LinkItemCollection HeaderLinks { get; set; }
        public LinkItemCollection SupportPages { get; set; }
        public LinkItemCollection CompanyInformationPages { get; set; }
        public LinkItemCollection SocialMedia { get; set; }
        public bool HideHeader { get; set; }
        public bool HideFooter { get; set; }

    }
}