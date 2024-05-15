using Npt_Lesson04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Npt_Lesson04.Controllers
{
    public class NptCustomerController : Controller
    {
        // GET: NptCustomer
        public ActionResult Index()
        {
            return View();
        }

        //action customer detailed
        public ActionResult NptCustomerDetail()
        {
            //tao doi tuong du lieu
            var customer = new NPTCustomer()
            {
                CustomerId = 1,
                FirstName = "Nguyen Phong",
                LastName = "Tan",
                Address = "K22CNT3",
                YearOfBirth = 2004
            };
            ViewBag.Customer = customer;
            return View();
        }
        public ActionResult NptListCustomer()
        {
            var list = new List<NPTCustomer>()
            {
                new NPTCustomer()
                {
                    CustomerId = 1,
                    FirstName = "Nguyen Phong",
                    LastName = "Tan",
                    Address = "K22CNT3",
                    YearOfBirth = 2004
                },
                new NPTCustomer()
                {
                    CustomerId = 2,
                    FirstName = "Lumina",
                    LastName = "Tanami",
                    Address = "K22CNT3",
                    YearOfBirth = 2004
                },
                new NPTCustomer()
                {
                    CustomerId = 3,
                    FirstName = "Usagiri",
                    LastName = "Tanami",
                    Address = "K22CNT3",
                    YearOfBirth = 2004
                }
        };
            //ViewBag.list = list; //dau du lieu ra view bang viewbag
          return View(list);
        }
    }
}