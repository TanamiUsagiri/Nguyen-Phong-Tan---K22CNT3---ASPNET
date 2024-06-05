using NPT_Lesson06_Entity_FrameWork.Models;
using NptLesson06CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NPT_Lesson06_Entity_FrameWork.Controllers
{
    public class NPTCategoriesController : Controller
    {
        private static NptBookStore nptDb;
        public NPTCategoriesController()
        {
            nptDb = new NptBookStore();
        }
        // GET: NPTCategories
        public ActionResult NptIndex()
        {
            /*
            * Khởi tạo DbContext:
            * EF sẽ tìm thông tin kết nối trong file machinee.config của .NET FreamWork trên máy 
            * và sau đó tạo csdl 
            * */
            //NptBookStore NptDb = new NptBookStore();
            var NptCategories = nptDb.NPTCategories.ToList();
            return View(NptCategories);
        }
        public ActionResult NptCreate()
        {
            var nptcategory = new NPTCategory();
            return View(nptcategory);
        }
        [HttpPost]
        public ActionResult NptCreate(NPTCategory nPTCategory)
        {
            nptDb.NPTCategories.Add(nPTCategory);
            nptDb.SaveChanges();
            return RedirectToAction("NptIndex");
        }
    }
}