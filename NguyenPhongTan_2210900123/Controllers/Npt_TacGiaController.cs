using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NguyenPhongTan_2210900123.Models;

namespace NguyenPhongTan_2210900123.Controllers
{
    public class Npt_TacGiaController : Controller
    {
        private NguyenPhongTan_2210900123Entities db = new NguyenPhongTan_2210900123Entities();

        // GET: Npt_TacGia
        public ActionResult NPTIndex()
        {
            var npt_TacGia = db.Npt_TacGia.Include(n => n.Npt_Sach);
            return View(npt_TacGia.ToList());
        }

        // GET: Npt_TacGia/Details/5
        public ActionResult NPTDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Npt_TacGia npt_TacGia = db.Npt_TacGia.Find(id);
            if (npt_TacGia == null)
            {
                return HttpNotFound();
            }
            return View(npt_TacGia);
        }

        // GET: Npt_TacGia/Create
        public ActionResult NPTCreate()
        {
            ViewBag.Npt_MaTG = new SelectList(db.Npt_Sach, "Npt_Masach", "Npt_Tensach");
            return View();
        }

        // POST: Npt_TacGia/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NPTCreate([Bind(Include = "Npt_MaTG,Npt_TenTG")] Npt_TacGia npt_TacGia)
        {
            if (ModelState.IsValid)
            {
                db.Npt_TacGia.Add(npt_TacGia);
                db.SaveChanges();
                return RedirectToAction("NPTIndex");
            }

            ViewBag.Npt_MaTG = new SelectList(db.Npt_Sach, "Npt_Masach", "Npt_Tensach", npt_TacGia.Npt_MaTG);
            return View(npt_TacGia);
        }

        // GET: Npt_TacGia/Edit/5
        public ActionResult NPTEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Npt_TacGia npt_TacGia = db.Npt_TacGia.Find(id);
            if (npt_TacGia == null)
            {
                return HttpNotFound();
            }
            ViewBag.Npt_MaTG = new SelectList(db.Npt_Sach, "Npt_Masach", "Npt_Tensach", npt_TacGia.Npt_MaTG);
            return View(npt_TacGia);
        }

        // POST: Npt_TacGia/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NPTEdit([Bind(Include = "Npt_MaTG,Npt_TenTG")] Npt_TacGia npt_TacGia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(npt_TacGia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NPTIndex");
            }
            ViewBag.Npt_MaTG = new SelectList(db.Npt_Sach, "Npt_Masach", "Npt_Tensach", npt_TacGia.Npt_MaTG);
            return View(npt_TacGia);
        }

        // GET: Npt_TacGia/Delete/5
        public ActionResult NPTDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Npt_TacGia npt_TacGia = db.Npt_TacGia.Find(id);
            if (npt_TacGia == null)
            {
                return HttpNotFound();
            }
            return View(npt_TacGia);
        }

        // POST: Npt_TacGia/Delete/5
        [HttpPost, ActionName("NPTDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult NPTDeleteConfirmed(string id)
        {
            Npt_TacGia npt_TacGia = db.Npt_TacGia.Find(id);
            db.Npt_TacGia.Remove(npt_TacGia);
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
