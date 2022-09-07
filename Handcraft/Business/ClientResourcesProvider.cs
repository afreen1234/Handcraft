using EPiServer.Framework.Web.Resources;
using EPiServer.Shell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Handcraft.Business
{
    [ClientResourceProvider]
    public class ClientResourcesProvider : IClientResourceProvider
    {
        public IEnumerable<ClientResource> GetClientResources()
        {
            return new[]
        {
            new ClientResource
            {
                //Name = "epi.samples.Module.FormHandler",
                //Path = Paths.ToClientResource("HandcraftModule", "ClientResources/FormHandler.js"),
                //ResourceType = ClientResourceType.Script,
                //Dependencies = new List<string> { "OtherResourceName" }
            }
        };
        }
    }
}