using EpiserverSiteFromScratch.Models.Blocks;

namespace EpiserverSiteFromScratch.Models.ViewModels
{
    public class TeaserBlockViewModel
    {
        public TeaserBlock CurrentBlock { get; set; }
        public int TodaysVisitorCount { get; set; }
    }
}