using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using EPiServer.Web;

namespace EpiserverSiteFromScratch.Models.Blocks
{
    [ContentType(DisplayName = "EventsBlock", GUID = "06bdef31-65ba-4aaa-ba75-dbe97c3eab94", Description = "2 bilder")]
    public class EventsBlock : BlockData
    {
        [CultureSpecific]
        [Display(
            Name = "header",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual string Header { get; set; }

        [CultureSpecific]
        [Display(
            Name = "text under header",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual string Text { get; set; }


        [CultureSpecific]
        [Display(
            Name = "image",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 300)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [CultureSpecific]
        [Display(
            Name = "image2",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 300)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image2 { get; set; }
    }
}