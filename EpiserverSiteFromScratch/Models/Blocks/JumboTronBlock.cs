using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace EpiserverSiteFromScratch.Models.Blocks
{
    [ContentType(DisplayName = "jumboronblock", GUID = "e2da997f-ddd6-4b36-a84c-4dfd016b83ee", Description = "")]
    public class JumboTronBlock : BlockData
    {

        //[CultureSpecific]
        //[Display(
        //    Name = "Name",
        //    Description = "Name field's description",
        //    GroupName = SystemTabNames.Content,
        //    Order = 10)]
        //public virtual string Name { get; set; }

        [Display(Name = "Image", Order = 30)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference TeaserImage { get; set; }
    }
}