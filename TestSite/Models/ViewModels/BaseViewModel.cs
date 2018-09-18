using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestSite.Models.ViewModels
{
    public class BaseViewModel<T> : IPageViewModel<T> where T : PageData
    {
        public BaseViewModel(T currentPage)
        {
            CurrentPage = currentPage;
        }

        public T CurrentPage { get; private set; }

        public LayoutViewModel Layout { get; set; }
    }
}