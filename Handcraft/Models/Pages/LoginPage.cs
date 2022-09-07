using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.ComponentModel.DataAnnotations;

namespace Handcraft.Models.Pages
{
    [ContentType(DisplayName = "LoginPage", GUID = "6328b0cb-fdf4-42fa-ad9d-8040947407de", Description = "")]
    [SiteContentType(GroupName = Global.GroupNames.Specialized)]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "page-type-thumbnail-article.png")]
    public class LoginPage : SitePageData
    {
        
    }
}