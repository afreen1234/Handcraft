using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Handcraft
{
    public class Global
    {
        [GroupDefinitions()]
        public static class GroupNames
        {

            [Display(Name = "SiteSettings", Order = 300)]
            public const string SiteSettings = "SiteSettings";
        }
        public static class ContentAreaTags
        {
            public const string FullWidth = "span12";
            public const string TwoThirdsWidth = "span8";
            public const string HalfWidth = "span6";
            public const string OneThirdWidth = "span4";
            public const string NoRenderer = "norenderer";
        }
    }
}