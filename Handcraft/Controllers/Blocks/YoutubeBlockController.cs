using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using Handcraft.Models.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Handcraft.Controllers.Blocks
{
    public class YoutubeBlockController : BlockController<YoutubeBlock>
    {
        public override ActionResult Index(YoutubeBlock currentBlock)
        {
            return PartialView("_Youtube",currentBlock);
        }
    }
}
