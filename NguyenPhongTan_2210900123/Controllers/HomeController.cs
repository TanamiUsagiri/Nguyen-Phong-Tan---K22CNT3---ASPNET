using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenPhongTan_2210900123.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult NPTIndex()
        {
            return View();
        }

        public ActionResult NPTAbout()
        {
            ViewBag.Message = "Nguyen Phong Tan - 2210900123";

            return View();
        }

        public ActionResult NPTContact()
        {
            ViewBag.Message = "Tanami";

            return View();
        }
    }
}