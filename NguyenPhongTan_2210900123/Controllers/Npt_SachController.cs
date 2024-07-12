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
    public class Npt_SachController : Controller
    {
        private NguyenPhongTan_2210900123Entities db = new NguyenPhongTan_2210900123Entities();

        // GET: Npt_Sach
        public ActionResult NPTIndex()
        {
            var npt_Sach = db.Npt_Sach.Include(n => n.Npt_TacGia);
            return View(npt_Sach.ToList());
        }

        // GET: Npt_Sach/Details/5
        public ActionResult NPTDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Npt_Sach npt_Sach = db.Npt_Sach.Find(id);
            if (npt_Sach == null)
            {
                return HttpNotFound();
            }
            return View(npt_Sach);
        }

        // GET: Npt_Sach/Create
        public ActionResult NPTCreate()
        {
            ViewBag.Npt_Masach = new SelectList(db.Npt_TacGia, "Npt_MaTG", "Npt_TenTG");
            return View();
        }

        // POST: Npt_Sach/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NPTCreate([Bind(Include = "Npt_Masach,Npt_Tensach,Npt_Sotrang,Npt_NamXB,Npt_MaTG,Npt_Trangthai")] Npt_Sach npt_Sach)
        {
            if (ModelState.IsValid)
            {
                db.Npt_Sach.Add(npt_Sach);
                db.SaveChanges();
                return RedirectToAction("NPTIndex");
            }

            ViewBag.Npt_Masach = new SelectList(db.Npt_TacGia, "Npt_MaTG", "Npt_TenTG", npt_Sach.Npt_Masach);
            return View(npt_Sach);
        }

        // GET: Npt_Sach/Edit/5
        public ActionResult NPTEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Npt_Sach npt_Sach = db.Npt_Sach.Find(id);
            if (npt_Sach == null)
            {
                return HttpNotFound();
            }
            ViewBag.Npt_Masach = new SelectList(db.Npt_TacGia, "Npt_MaTG", "Npt_TenTG", npt_Sach.Npt_Masach);
            return View(npt_Sach);
        }

        // POST: Npt_Sach/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NPTEdit([Bind(Include = "Npt_Masach,Npt_Tensach,Npt_Sotrang,Npt_NamXB,Npt_MaTG,Npt_Trangthai")] Npt_Sach npt_Sach)
        {
            if (ModelState.IsValid)
            {
                db.Entry(npt_Sach).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NPTIndex");
            }
            ViewBag.Npt_Masach = new SelectList(db.Npt_TacGia, "Npt_MaTG", "Npt_TenTG", npt_Sach.Npt_Masach);
            return View(npt_Sach);
        }

        // GET: Npt_Sach/Delete/5
        public ActionResult NPTDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Npt_Sach npt_Sach = db.Npt_Sach.Find(id);
            if (npt_Sach == null)
            {
                return HttpNotFound();
            }
            return View(npt_Sach);
        }

        // POST: Npt_Sach/Delete/5
        [HttpPost, ActionName("NPTDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult NPTDeleteConfirmed(string id)
        {
            Npt_Sach npt_Sach = db.Npt_Sach.Find(id);
            db.Npt_Sach.Remove(npt_Sach);
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
