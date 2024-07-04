 using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NPTK22CNT3Lesson11_2210900037.Models;

namespace NPTK22CNT3Lesson11_2210900037.Controllers
{
    public class NPTCategoriesController : Controller
    {
        private NptK22CNT3_Lesson11Entities db = new NptK22CNT3_Lesson11Entities();

        // GET: NPTCategories
        public ActionResult NPTIndex()
        {
            return View(db.NPTCategories.ToList());
        }

        // GET: NPTCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NPTCategory lHLCategory = db.NPTCategories.Find(id);
            if (lHLCategory == null)
            {
                return HttpNotFound();
            }
            return View(lHLCategory);
        }

        // GET: NPTCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NPTCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NptId,NptCateName,NptStatus")] NPTCategory lHLCategory)
        {
            if (ModelState.IsValid)
            {
                db.NPTCategories.Add(lHLCategory);
                db.SaveChanges();
                return RedirectToAction("NPTIndex");
            }

            return View(lHLCategory);
        }

        // GET: NPTCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NPTCategory lHLCategory = db.NPTCategories.Find(id);
            if (lHLCategory == null)
            {
                return HttpNotFound();
            }
            return View(lHLCategory);
        }

        // POST: NPTCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NptId,NptCateName,NptStatus")] NPTCategory lHLCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lHLCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NPTIndex");
            }
            return View(lHLCategory);
        }

        // GET: NPTCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NPTCategory lHLCategory = db.NPTCategories.Find(id);
            if (lHLCategory == null)
            {
                return HttpNotFound();
            }
            return View(lHLCategory);
        }

        // POST: NPTCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NPTCategory lHLCategory = db.NPTCategories.Find(id);
            db.NPTCategories.Remove(lHLCategory);
            db.SaveChanges();
            return RedirectToAction("NPTIndex");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
