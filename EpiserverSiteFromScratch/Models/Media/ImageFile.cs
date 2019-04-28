using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;
using System;

namespace EpiserverSiteFromScratch.Models.Media
{
    [ContentType(DisplayName = "ImageFile", GUID = "496f4b92-af2e-44a0-a00b-b1c9d44f12c7", Description = "")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,ico,gif,bmp,png")]
    public class ImageFile : ImageData
    {
        //// <summary>
        /// Gets or sets the copyright.
        /// </summary>
        public virtual string Copyright { get; set; }

        public virtual String Description { get; set; }
    }
}