using AutoMapper;
using Sandbox461.Data;
using Sandbox461.Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sandbox461.Website.Controllers
{
    public partial class HomeController : Controller
    {
        public virtual ActionResult Index()
        {
            Session.Add("testkey", "testvalue");
            return View();
        }

        public virtual ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public virtual ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public virtual ActionResult Upload()
        {
            ViewBag.Message = "Upload page.";

            return View();
        }


        public virtual ActionResult Save()
        {
            ViewBag.Message = "Upload page.";

            return View("Upload");
        }

        public virtual ActionResult UploadAjax(List<HttpPostedFileBase> files)
        {
            List<SupportedDocument> docs = TempData["docs"] as List<SupportedDocument> ?? new List<SupportedDocument>();

            foreach (var file in files)
            {
                var doc = Mapper.Map<SupportedDocument>(file);
                docs.Add(doc);
            }

            if (TempData.ContainsKey("docs"))
                TempData.Add("docs", docs);
            else
                TempData["docs"] = docs;

            return Json(files.Select(x => new { name = x.FileName }));
        }
    }
}