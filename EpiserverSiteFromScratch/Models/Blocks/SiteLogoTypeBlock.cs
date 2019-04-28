using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace EpiserverSiteFromScratch.Models.Blocks
{
    [ContentType(DisplayName = "SiteLogoTypeBlock",
        GUID = "dd1e9f09-2733-4e6b-9d0d-102cfcf3a413",
        Description = "",
        AvailableInEditMode = false)]
    public class SiteLogoTypeBlock : BlockData
    {
        /// <summary>
        /// Gets the site logotype URL
        /// </summary>
        /// <remarks>If not specified a default logotype will be used</remarks>
        [DefaultDragAndDropTarget]
        [UIHint(UIHint.Image)]
        public virtual Url Url
        {
            get
            {
                var url = this.GetPropertyValue(b => b.Url);

                return url == null || url.IsEmpty()
                    ? new Url("/Static/gfx/logotype.png")
                    : url;
            }
            set
            {
                this.SetPropertyValue(b => b.Url, value);
            }
        }

        [CultureSpecific]
        public virtual string Title { get; set; }
    }
}