﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using TestSite.Models.Pages;
using TestSite.Models.ViewModels;

namespace TestSite.Controllers
{
    public class ArticlePageController : PageController<ArticlePage>
    {
        public ActionResult Index(ArticlePage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return View("Index", new BaseViewModel<ArticlePage>(currentPage));
        }
    }
}