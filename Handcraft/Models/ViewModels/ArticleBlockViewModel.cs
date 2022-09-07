using EPiServer.Core;
using EPiServer.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Handcraft.Models.ViewModels
{
    public class ArticleBlockViewModel
    {
        public virtual string Title { get; set; }

        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [UIHint(UIHint.Textarea)]
        public virtual XhtmlString Description { get; set; }
    }
}