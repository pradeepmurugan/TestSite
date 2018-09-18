using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace Test_Site.Models.Pages
{
    [ContentType(DisplayName = "StandardPage", GUID = "5082915f-367f-4de8-ac83-fa4694587916", Description = "")]
    public class StandardPage : PageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Description", GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual string Description { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Content Area", GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual ContentArea ContentArea1 { get; set; }

    }
}