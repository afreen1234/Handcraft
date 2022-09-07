using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Handcraft.Models
{
    public class SiteImageUrl : ImageUrlAttribute
    {
        public SiteImageUrl() : base("~/Static/gfx/page-type-thumbnail.png")
        {

        }

        public SiteImageUrl(string path) : base(path)
        {

        }
    }
}