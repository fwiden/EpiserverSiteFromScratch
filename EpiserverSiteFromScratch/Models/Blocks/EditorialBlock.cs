using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace EpiserverSiteFromScratch.Models.Blocks
{
    [ContentType(DisplayName = "Editorial",
        GroupName = "Textblock",
        Description = "Use this for a rich editorial text that will be reused in multiple places.")]
    
    public class EditorialBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual XhtmlString MainBody { get; set; }
    }
}