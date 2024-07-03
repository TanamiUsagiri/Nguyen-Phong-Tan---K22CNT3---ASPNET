using NptK22CNT3Lesson10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NptK22CNT3Lesson10.Controllers
{
    public class NptHomeController : Controller
    {
        public ActionResult NptIndex()
        {
            //Check valid data session
            if (Session["NptAccount"] != null)
            {
                var NptAccount = Session["NptAccount"] as NptAccount;
                ViewBag.FullName = NptAccount.NptFullName;
            }
            return View();
        }

        public ActionResult NptAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult NptContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}