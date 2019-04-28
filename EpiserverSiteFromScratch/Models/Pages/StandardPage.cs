using EPiServer.Cms.Shell.UI.ObjectEditing.EditorDescriptors.SelectionFactories;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using System.ComponentModel.DataAnnotations;

namespace EpiserverSiteFromScratch.Models.Pages
{
    [ContentType(DisplayName = "StandardPage", GUID = "76a954c6-9466-4933-a862-f8bae4a89063", Description = "StandardPage", AvailableInEditMode = false)]
    public class StandardPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Header",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual string Header { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Firstname:",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 300)]
        public virtual string FirstName { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Lastname:",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 400)]
        public virtual string LastName { get; set; }

        [CultureSpecific]
        [Display(
            Name = "School:",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 500)]
        public virtual string School { get; set; }

       

        [SelectMany(SelectionFactoryType = typeof(LanguageSelectionFactory))]
        public virtual string SingleLanguage { get; set; }
    }
}