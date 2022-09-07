using EPiServer.Cms.Shell.UI.ObjectEditing.EditorDescriptors;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.SpecializedProperties;
using Handcraft.Models.Blocks;
using Handcraft.Models.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Handcraft.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "2ca3f4d4-9e52-4828-9272-072eb7ee8995", Description = "")]
    public class StartPage : SitePageData
    {
        [Display(Name = "Main Content Area", GroupName = SystemTabNames.Content, Order = 100)]
        public virtual ContentArea MainContentArea { get; set; }

        [Display(Name = "Carousel Block", GroupName = SystemTabNames.Content, Order = 105)]
        public virtual CarouselBlock Carousel { get; set; }

        [Display(Name = "ArticleList Block" , GroupName = SystemTabNames.Content, Order = 106)]
        [EditorDescriptor(EditorDescriptorType = typeof(CollectionEditorDescriptor<ArticleBlockViewModel>))]
        public virtual IList<ArticleBlockViewModel> ArticleListBlock { get; set; }

        [Display(Name = "Header Items", GroupName = SystemTabNames.Content, Order = 110)]
        public virtual LinkItemCollection HeaderLinks { get; set; }

        [Display(Name ="Logo Block", GroupName = SystemTabNames.Content, Order = 115)]
        public virtual LogoBlock SiteLogotype { get; set; }

        [Display(Name = "Support", GroupName = SystemTabNames.Content, Order = 120)]
        public virtual LinkItemCollection SupportPages { get; set; }

        [Display(Name = "Comapany", GroupName = SystemTabNames.Content, Order = 125)]
        public virtual LinkItemCollection CompanyPages { get; set; }

        [Display(Name = "Social Media", GroupName = SystemTabNames.Content, Order = 130)]
        public virtual LinkItemCollection SocialmediaPages { get; set; }

    }
}