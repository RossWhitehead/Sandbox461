using Sandbox461.ViewModels.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sandbox461.Controllers
{
    public class TestController : Controller
    {
        // GET: Create
        public ActionResult Create()
        {
            return View("Create", new CreateVM() { EndDate = DateTime.Now });
        }

        // POST: Create
        [HttpPost]
        public ActionResult Create(CreateVM vm)
        {
            if (ModelState.IsValid)
            {

            }

            return View("Create", vm);
        }
    }
}