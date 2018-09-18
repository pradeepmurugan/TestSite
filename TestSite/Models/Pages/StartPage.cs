using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using TestSite.Models.Blocks;

namespace TestSite.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "c4c8a81b-f939-405a-b950-71c794e28f8d", Description = "")]
    public class StartPage : BasePage
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 0)]
        public virtual XhtmlString MainBody { get; set; }

        public virtual string Heading { get; set; }

        public virtual HeaderBlock HeaderBlock { get; set; }

    }
}