﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testVS2017p20190213.Models;

namespace testVS2017p20190213.Controllers
{
    public class HomeController : Controller
    {
        private MemberDBEntities db = new MemberDBEntities();
        public ActionResult Index()
        {
            return View(db.Members.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page. abc";

            return View();
        }        
        public ActionResult Test()
        {
            return View();
        }
    }
}