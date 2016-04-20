using Sandbox461.ViewModels.Default;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sandbox461.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            var vm = new TestIndexViewModel { Name = "Ross Whitehead", SelectedCategoryId = 3, StartDate = new DateTime(2012, 1, 1) };
            return View("Index", vm);
        }
    }
}