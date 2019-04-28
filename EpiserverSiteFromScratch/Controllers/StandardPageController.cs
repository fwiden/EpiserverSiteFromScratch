using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using EpiserverSiteFromScratch.Models.Pages;
using EpiserverSiteFromScratch.Models.ViewModels;
using System.Web.Mvc;

namespace EpiserverSiteFromScratch.Controllers
{
    public class StandardPageController : PageController<StandardPage>
    {
        public ActionResult Index(StandardPage currentPage)
        {
            var model = PageViewModel.Create(currentPage);

            return View(model);
        }

        [HttpPost]
        public ActionResult Save(StandardPage currentPage)
        {
            PageReference parent = ContentReference.StartPage;
            IContentRepository repo = ServiceLocator.Current.GetInstance<IContentRepository>();
            StandardPage page = repo.GetDefault<StandardPage>(parent);

            page.Name = "PageNeme";
            page.School = "Smedis";
            page.FirstName = "Freddan";
            page.LastName = "Widen";
        

            repo.Save(page, EPiServer.DataAccess.SaveAction.Publish, EPiServer.Security.AccessLevel.NoAccess);

            return RedirectToAction("Index", new { node = ContentReference.StartPage });
        }
    }
}