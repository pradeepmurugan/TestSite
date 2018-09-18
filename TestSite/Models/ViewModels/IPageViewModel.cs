using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestSite.Models.ViewModels
{
    public interface IPageViewModel<out T> where T : PageData
    {
        LayoutViewModel Layout { get; set; }

        T CurrentPage { get; }
    }
}