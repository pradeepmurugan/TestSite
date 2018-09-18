using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Test_Site.Models.Pages;

namespace Test_Site.Models.Blocks
{
    [ContentType(DisplayName = "PageListBlock", GUID = "9bbc6804-f832-489d-8147-bb7e151e258d", Description = "")]
    public class PageListBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Name", Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Root Page",
            GroupName = SystemTabNames.Content, Order = 2)]
        public virtual PageReference Root { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Max Count", GroupName = SystemTabNames.Content, Order = 3)]
        public virtual int Count { get; set; }

        public List<(string name, string description)> GetPageNamesAndDescriptions()
        {
            var list = new List<(string name, string description)>();
            var children = DataFactory.Instance.GetChildren<StandardPage>(Root);
            foreach(var child in children)
            {
                list.Add((child.Name, child.Description));
            }
            return list;
        }
  


    }
}