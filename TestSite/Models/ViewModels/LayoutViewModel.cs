using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestSite.Models.Blocks;

namespace TestSite.Models.ViewModels
{
    public class LayoutViewModel
    {
        public string Header { get; set; }

        public string Footer { get; set; }

        public HeaderBlock Header1 { get; set; }
    }
}