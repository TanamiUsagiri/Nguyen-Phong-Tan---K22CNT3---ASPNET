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
    public class NPTProductsController : Controller
    {
        private NptK22CNT3_Lesson11Entities db = new NptK22CNT3_Lesson11Entities();

        // GET: NPTProducts
        public ActionResult NptIndex()
        {
            var lHLProducts = db.NPTProducts.Include(l => l.NPTCategory);
            return View(lHLProducts.ToList());
        }

        // GET: NPTProducts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NPTProduct lHLProduct = db.NPTProducts.Find(id);
            if (lHLProduct == null)
            {
                return HttpNotFound();
            }
            return View(lHLProduct);
        }

        // GET: NPTProducts/Create
        public ActionResult Create()
        {
            ViewBag.NptCateId = new SelectList(db.NPTCategories, "NptId", "NptCateName");
            return View();
        }

        // POST: NPTProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NptId2210900037,NptProName,NptQty,NptPrice,NptCateId,NptActive")] NPTProduct lHLProduct)
        {
            if (ModelState.IsValid)
            {
                db.NPTProducts.Add(lHLProduct);
                db.SaveChanges();
                return RedirectToAction("NptIndex");
            }

            ViewBag.NptCateId = new SelectList(db.NPTCategories, "NptId", "NptCateName", lHLProduct.NptCateId);
            return View(lHLProduct);
        }

        // GET: NPTProducts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NPTProduct lHLProduct = db.NPTProducts.Find(id);
            if (lHLProduct == null)
            {
                return HttpNotFound();
            }
            ViewBag.NptCateId = new SelectList(db.NPTCategories, "NptId", "NptCateName", lHLProduct.NptCateId);
            return View(lHLProduct);
        }

        // POST: NPTProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NptId2210900037,NptProName,NptQty,NptPrice,NptCateId,NptActive")] NPTProduct lHLProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lHLProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NptIndex");
            }
            ViewBag.NptCateId = new SelectList(db.NPTCategories, "NptId", "NptCateName", lHLProduct.NptCateId);
            return View(lHLProduct);
        }

        // GET: NPTProducts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NPTProduct lHLProduct = db.NPTProducts.Find(id);
            if (lHLProduct == null)
            {
                return HttpNotFound();
            }
            return View(lHLProduct);
        }

        // POST: NPTProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NPTProduct lHLProduct = db.NPTProducts.Find(id);
            db.NPTProducts.Remove(lHLProduct);
            db.SaveChanges();
            return RedirectToAction("NptIndex");
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
