﻿using EPiServer.Framework.Web.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Handcraft.Business
{
    [ClientResourceRegistrator]
    public class ClientResourceRegister : IClientResourceRegistrator
    {
        public void RegisterResources(IRequiredClientResourceList requiredResources)
        {
            //requiredResources.Require("epi.samples.Module.Styles");
            //requiredResources.Require("epi.samples.Module.FormHandler").AtFooter();
            //requiredResources.RequireScript("http://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.2.1.min.js").AtFooter();
        }
    }
}