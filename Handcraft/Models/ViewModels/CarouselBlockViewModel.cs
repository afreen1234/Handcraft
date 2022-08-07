using EPiServer.Core;
using EPiServer.DataAnnotations;
using Handcraft.Models.Blocks;
using Handcraft.Models.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Handcraft.Models.ViewModels
{
    public class CarouselBlockViewModel
    {
        public virtual List<SliderItem> Images { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual bool HideCaption { get; set; }
    }
}