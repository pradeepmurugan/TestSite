using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace TestSite.Models.Blocks
{
    [ContentType(DisplayName = "HeaderBlock", GUID = "39f16f18-1790-467e-bb42-765fd932f4f9", Description = "")]
    public class HeaderBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Name",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string HeaderName { get; set; }

    }
}