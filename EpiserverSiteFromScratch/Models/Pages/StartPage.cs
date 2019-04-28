using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace EpiserverSiteFromScratch.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "7c20e845-7fde-4c82-ad9b-43d1369a8a9d", Description = "StartPage")]
    public class StartPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Main content",
            Description = "The ",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual ContentArea Maincontentarea { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Header",
            Description = "Header",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Heading{ get; set; }

        [Display(
            Name = "logo sidhuvud",
            Description = "logo",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference logo { get; set; }

    }
}