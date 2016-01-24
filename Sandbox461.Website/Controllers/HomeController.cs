﻿using AutoMapper;
using Sandbox461.Data;
using Sandbox461.Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sandbox461.Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Session.Add("testkey", "testvalue");
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


        public ActionResult Save()
        {
            ViewBag.Message = "Upload page.";

            return View("Upload");
        }

        public ActionResult UploadAjax(List<HttpPostedFileBase> files)
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