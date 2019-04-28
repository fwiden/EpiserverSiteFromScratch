using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using EpiserverSiteFromScratch.Models.Pages;
using EpiserverSiteFromScratch.Models.ViewModels;
using System.Web.Mvc;

namespace EpiserverSiteFromScratch.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {

            var contentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();
            var startpage = contentLoader.Get<PageData>(ContentReference.StartPage);
            var logo = startpage.GetPropertyValue<ContentReference>("pageImage");

            var model = PageViewModel.Create(currentPage);

            return View(model);
        }
    }
}