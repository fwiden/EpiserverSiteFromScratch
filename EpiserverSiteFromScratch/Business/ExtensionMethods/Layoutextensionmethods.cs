using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EpiserverSiteFromScratch.Models.Pages;
using System.Web.Mvc;

namespace EpiserverSiteFromScratch.Business.ExtensionMethods
{
    public static class LayoutExtensionmethods
    {
        public static ContentReference RenderLogo(this HtmlHelper heper)
        {
            var loader = ServiceLocator.Current.GetInstance<IContentLoader>();
            var startPage = loader.Get<StartPage>(ContentReference.StartPage);
            return startPage.logo;

        }
    }
}