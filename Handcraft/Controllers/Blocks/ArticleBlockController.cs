using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using Handcraft.Models.Blocks;
using Handcraft.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Handcraft.Controllers.Blocks
{
    public class ArticleBlockController : BlockController<ArticleBlock>
    {
        public override ActionResult Index(ArticleBlock currentBlock)
        {
            var model = new ArticleBlockViewModel
            {
                Title = currentBlock.Title,
                Description = currentBlock.Description,
                Image = currentBlock.Image
            };
            return PartialView("_Article", model);
        }
    }
}
