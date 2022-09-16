using EPiServer;
using EPiServer.Core;
using EPiServer.Data;
using EPiServer.Web;
using EPiServer.Web.Routing;
using Handcraft.Models.Pages;
using Handcraft.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Handcraft.Business
{
    public class PageViewContextFactory
    {
        private readonly IContentLoader _contentLoader;
        //private readonly UrlResolver _urlResolver;
        //private readonly IDatabaseMode _databaseMode;

        public PageViewContextFactory(IContentLoader contentLoader /* UrlResolver urlResolver, IDatabaseMode databaseMode*/)
        {
            _contentLoader = contentLoader;
            //_urlResolver = urlResolver;
            //_databaseMode = databaseMode;
        }
        public virtual LayoutModel CreateLayoutModel(ContentReference currentContentLink, RequestContext requestContext)
        {
            var startPageContentLink = SiteDefinition.Current.StartPage;
            if (currentContentLink.CompareToIgnoreWorkID(startPageContentLink))
            {
                startPageContentLink = currentContentLink;
            }
            var startPage = _contentLoader.Get<StartPage>(startPageContentLink);

            return new LayoutModel
            {
                HeaderLinks = startPage.HeaderLinks,
                Carousel = startPage.Carousel,
                Logo = startPage.SiteLogotype,
                SupportPages = startPage.SupportPages,
                CompanyInformationPages = startPage.CompanyPages,
                SocialMedia = startPage.SocialmediaPages
            };
        }
    }
}