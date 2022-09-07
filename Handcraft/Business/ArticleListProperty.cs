using EPiServer.Core;
using EPiServer.PlugIn;
using Handcraft.Models.Blocks;
using Handcraft.Models.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Handcraft.Business
{
    [PropertyDefinitionTypePlugIn]
    public class ArticleListProperty : PropertyListBase<ArticleBlockViewModel> 
    {
       
    }
}