using AutoMapper;
using Sandbox461.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sandbox461.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Upload()
        {
            ViewBag.Message = "Upload page.";

            return View();
        }

        public ActionResult UploadAjax(List<HttpPostedFileBase> files)
        {
            foreach (var file in files)
            {
                var doc = Mapper.Map<SupportedDocument>(file);
            }

            return Json(files.Select(x => new { name = x.FileName }));
        }
    }
}