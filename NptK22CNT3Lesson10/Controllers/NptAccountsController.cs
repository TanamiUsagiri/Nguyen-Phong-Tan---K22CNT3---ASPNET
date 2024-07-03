using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NptK22CNT3Lesson10.Models;

namespace NptK22CNT3Lesson10.Controllers
{
    public class NptAccountsController : Controller
    {
        private NptK22CNT3Lesson10Entities db = new NptK22CNT3Lesson10Entities();

        // GET: NptAccounts
        public ActionResult Index()
        {
            return View(db.NptAccounts.ToList());
        }

        // GET: NptAccounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NptAccount nptAccount = db.NptAccounts.Find(id);
            if (nptAccount == null)
            {
                return HttpNotFound();
            }
            return View(nptAccount);
        }

        // GET: NptAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NptAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NptId,NptUserName,NptPassword,NptFullName,NptEmail,Nptphone,NptActive")] NptAccount nptAccount)
        {
            if (ModelState.IsValid)
            {
                db.NptAccounts.Add(nptAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nptAccount);
        }

        // GET: NptAccounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NptAccount nptAccount = db.NptAccounts.Find(id);
            if (nptAccount == null)
            {
                return HttpNotFound();
            }
            return View(nptAccount);
        }

        // POST: NptAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NptId,NptUserName,NptPassword,NptFullName,NptEmail,Nptphone,NptActive")] NptAccount nptAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nptAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nptAccount);
        }

        // GET: NptAccounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NptAccount nptAccount = db.NptAccounts.Find(id);
            if (nptAccount == null)
            {
                return HttpNotFound();
            }
            return View(nptAccount);
        }

        // POST: NptAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NptAccount nptAccount = db.NptAccounts.Find(id);
            db.NptAccounts.Remove(nptAccount);
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
        //Login
        public ActionResult NptLogin()
        {
            var NptModel = new NptAccount();
            return View(NptModel);
        }
        [HttpPost]
        public ActionResult NptLogin(NptAccount nptAccount)
        {
            var NptCheck = db.NptAccounts.Where(x => x.NptUserName.Equals(nptAccount.NptUserName) && x.NptPassword.Equals(nptAccount.NptPassword)).FirstOrDefault();
            if (NptCheck != null)
            {
                //Save Session
                Session["NptAccount"] = NptCheck;
                return Redirect("/");
            }
            return View(nptAccount);
        }
    }
}
