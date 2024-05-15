using Npt_Lesson04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Npt_Lesson04.Controllers
{
    public class NptCustomerScaffoldingController : Controller
    {
        //moc data
        private List<NPTCustomer> ListCustomer = new List<NPTCustomer>()
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
    // GET: NptCustomerScaffolding
    //listcustomer
    public ActionResult Index()
        {
            return View(ListCustomer);
        }
        [HttpGet]
        public ActionResult NptCreate()
        { 
            var model = new NPTCustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult NptCreate(NPTCustomer model)
        { 
            ListCustomer.Add(model);
            return RedirectToAction("Index");
        }

        public ActionResult NptEdit(int id)
        {
            var customer = ListCustomer.FirstOrDefault(x=>x.CustomerId==id);
            return View(customer);
        }
    }
}