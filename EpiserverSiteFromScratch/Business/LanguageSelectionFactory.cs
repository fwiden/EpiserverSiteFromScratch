using EPiServer.Shell.ObjectEditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiserverSiteFromScratch.Business
{
    public class LanguageSelectionFactory: ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            return new ISelectItem[] { new SelectItem() { Text = "English", Value = "EN" }, new SelectItem() { Text = "Guinean", Value = "GN" } };
        }
    }
}