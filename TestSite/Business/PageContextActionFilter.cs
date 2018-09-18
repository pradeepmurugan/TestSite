using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestSite.Models.Blocks;
using TestSite.Models.Pages;
using TestSite.Models.ViewModels;

namespace TestSite.Business
{
    public class PageContextActionFilter :  IResultFilter
    { 
        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            var model = filterContext.Controller.ViewData.Model;

            if (model is IPageViewModel<BasePage> layoutModel)
            {
                var startPage = ServiceLocator.Current.GetInstance<IContentLoader>().Get<StartPage>(SiteDefinition.Current.StartPage);
                HeaderBlock headerBlock;
                if(startPage == null)
                {
                    headerBlock = new HeaderBlock();
                    headerBlock.HeaderName = "Default Header - Start page doesn't exist";
                }
                else
                {
                    headerBlock = startPage.HeaderBlock;
                }
                var layout = new LayoutViewModel()
                {
                    Header1 = headerBlock
                };
                (model as IPageViewModel<PageData>).Layout = layout;
            }
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
        }
    }
}