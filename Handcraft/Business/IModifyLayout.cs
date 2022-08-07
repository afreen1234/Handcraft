using Handcraft.Models.ViewModels;
using System.Web.Mvc;

namespace Handcraft.Business
{
    interface IModifyLayout 
    {
        void ModifyLayout(LayoutModel layoutModel);
    }
}