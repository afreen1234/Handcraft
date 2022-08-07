using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using Handcraft.Models.Blocks;
using Handcraft.Models.Media;
using Handcraft.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Handcraft.Controllers.Blocks
{
    public class CarouselBlockController : BlockController<CarouselBlock>
    {
        public override ActionResult Index(CarouselBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
