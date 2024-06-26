using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NptLesson09.Models;

namespace NptLesson09.Controllers
{
    public class NptKhoasController : Controller
    {
        private NptK22CNT3Lesson09DbEntities db = new NptK22CNT3Lesson09DbEntities();

        // GET: NptKhoas
        public ActionResult NptIndex()
        {
            return View(db.nptKhoas.ToList());
        }

        // GET: NptKhoas/Details/5
        public ActionResult NptDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nptKhoa nptKhoa = db.nptKhoas.Find(id);
            if (nptKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nptKhoa);
        }

        // GET: NptKhoas/Create
        public ActionResult NptCreate()
        {
            return View();
        }

        // POST: NptKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NptCreate([Bind(Include = "NptmaKH,NptTenKH,NptTrangthai")] nptKhoa nptKhoa)
        {
            if (ModelState.IsValid)
            {
                db.nptKhoas.Add(nptKhoa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nptKhoa);
        }

        // GET: NptKhoas/Edit/5
        public ActionResult NptEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nptKhoa nptKhoa = db.nptKhoas.Find(id);
            if (nptKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nptKhoa);
        }

        // POST: NptKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NptEdit([Bind(Include = "NptmaKH,NptTenKH,NptTrangthai")] nptKhoa nptKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nptKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nptKhoa);
        }

        // GET: NptKhoas/Delete/5
        public ActionResult NptDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nptKhoa nptKhoa = db.nptKhoas.Find(id);
            if (nptKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nptKhoa);
        }

        // POST: NptKhoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult NptDeleteConfirmed(string id)
        {
            nptKhoa nptKhoa = db.nptKhoas.Find(id);
            db.nptKhoas.Remove(nptKhoa);
            db.SaveChanges();
            return RedirectToAction("Index");
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
