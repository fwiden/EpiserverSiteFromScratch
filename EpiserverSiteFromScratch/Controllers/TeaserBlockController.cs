using EPiServer.Web.Mvc;
using EpiserverSiteFromScratch.Models.Blocks;
using EpiserverSiteFromScratch.Models.ViewModels;
using System;
using System.Web.Mvc;

namespace EpiserverSiteFromScratch.Controllers
{
    public class TeaserBlockController : BlockController<TeaserBlock>
    {
        public override ActionResult Index(TeaserBlock currentBlock)
        {
            var viewmodel = new TeaserBlockViewModel
            {
                CurrentBlock = currentBlock,
                TodaysVisitorCount = (new Random()).Next(300, 900)
            };
            return PartialView(viewmodel);
        }
    }
}
