using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace EpiserverSiteFromScratch.Models.Pages
{

    /// <summary>
    /// Base class for all page types
    /// </summary>
    public abstract class SitePageData : PageData
    {
        

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 100)]
        [DefaultDragAndDropTarget]
        [UIHint(UIHint.Image)]
        public virtual ContentReference PageImage { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 200)]
        [CultureSpecific]
        [UIHint(UIHint.Textarea)]
        public virtual string TeaserText
        {
            get
            {
                var teaserText = this.GetPropertyValue(p => p.TeaserText);

                // Use explicitly set teaser text, otherwise fall back to description
                return !string.IsNullOrWhiteSpace(teaserText)
                    ? teaserText
                    : MetaDescription;
            }
            set { this.SetPropertyValue(p => p.TeaserText, value); }
        }


        [Display(
            GroupName = "Metadata",
            Order = 300)]
        [CultureSpecific]
        [UIHint(UIHint.Textarea)]
        public virtual string MetaDescription { get; set; }

    }
}