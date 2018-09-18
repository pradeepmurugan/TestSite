using System.Collections.Generic;
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
    public class StartPageController : PageController<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            return View("Index", new BaseViewModel<StartPage>(currentPage));
        }
    }
}