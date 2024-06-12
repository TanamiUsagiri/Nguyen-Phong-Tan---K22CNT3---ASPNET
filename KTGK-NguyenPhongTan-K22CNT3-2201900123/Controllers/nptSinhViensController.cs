using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KTGK_NguyenPhongTan_K22CNT3_2201900123.Models;

namespace KTGK_NguyenPhongTan_K22CNT3_2201900123.Controllers
{
    public class nptSinhViensController : Controller
    {
        private Entities1 db = new Entities1();

        // GET: nptSinhViens
        public ActionResult nptIndex()
        {
            var nptSinhViens = db.nptSinhViens.Include(n => n.nptKhoa);
            return View(nptSinhViens.ToList());
        }

        // GET: nptSinhViens/Details/5
        public ActionResult nptDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nptSinhVien nptSinhVien = db.nptSinhViens.Find(id);
            if (nptSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(nptSinhVien);
        }

        // GET: nptSinhViens/Create
        public ActionResult nptCreate()
        {
            ViewBag.nptMaKH = new SelectList(db.nptKhoas, "nptMaKH", "nptTenKH");
            return View();
        }

        // POST: nptSinhViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult nptCreate([Bind(Include = "nptMaSV,nptHoSV,nptTenSV,nptNgaySinh,nptPhai,nptPhone,nptEmail,nptMaKH")] nptSinhVien nptSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.nptSinhViens.Add(nptSinhVien);
                db.SaveChanges();
                return RedirectToAction("nptIndex");
            }

            ViewBag.nptMaKH = new SelectList(db.nptKhoas, "nptMaKH", "nptTenKH", nptSinhVien.nptMaKH);
            return View(nptSinhVien);
        }

        // GET: nptSinhViens/Edit/5
        public ActionResult nptEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nptSinhVien nptSinhVien = db.nptSinhViens.Find(id);
            if (nptSinhVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.nptMaKH = new SelectList(db.nptKhoas, "nptMaKH", "nptTenKH", nptSinhVien.nptMaKH);
            return View(nptSinhVien);
        }

        // POST: nptSinhViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult nptEdit([Bind(Include = "nptMaSV,nptHoSV,nptTenSV,nptNgaySinh,nptPhai,nptPhone,nptEmail,nptMaKH")] nptSinhVien nptSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nptSinhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("nptIndex");
            }
            ViewBag.nptMaKH = new SelectList(db.nptKhoas, "nptMaKH", "nptTenKH", nptSinhVien.nptMaKH);
            return View(nptSinhVien);
        }

        // GET: nptSinhViens/Delete/5
        public ActionResult nptDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nptSinhVien nptSinhVien = db.nptSinhViens.Find(id);
            if (nptSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(nptSinhVien);
        }

        // POST: nptSinhViens/Delete/5
        [HttpPost, ActionName("nptDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult nptDeleteConfirmed(string id)
        {
            nptSinhVien nptSinhVien = db.nptSinhViens.Find(id);
            db.nptSinhViens.Remove(nptSinhVien);
            db.SaveChanges();
            return RedirectToAction("nptIndex");
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
