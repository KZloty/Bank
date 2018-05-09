using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Bank.WebUI.Models;

namespace Bank.WebUI.Controllers
{
    public class KlientController : Controller
    {
        private BankWebUIContext db = new BankWebUIContext();

        // GET: Klient
        public ActionResult Index()
        {
            return View(db.KlientViewModels.ToList());
        }

        // GET: Klient/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KlientViewModel klientViewModel = db.KlientViewModels.Find(id);
            if (klientViewModel == null)
            {
                return HttpNotFound();
            }
            return View(klientViewModel);
        }

        // GET: Klient/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Klient/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "KlientID,Imie,Nazwisko,PESEL")] KlientViewModel klientViewModel)
        {
            if (ModelState.IsValid)
            {
                db.KlientViewModels.Add(klientViewModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(klientViewModel);
        }

        // GET: Klient/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KlientViewModel klientViewModel = db.KlientViewModels.Find(id);
            if (klientViewModel == null)
            {
                return HttpNotFound();
            }
            return View(klientViewModel);
        }

        // POST: Klient/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "KlientID,Imie,Nazwisko,PESEL")] KlientViewModel klientViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(klientViewModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(klientViewModel);
        }

        // GET: Klient/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KlientViewModel klientViewModel = db.KlientViewModels.Find(id);
            if (klientViewModel == null)
            {
                return HttpNotFound();
            }
            return View(klientViewModel);
        }

        // POST: Klient/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            KlientViewModel klientViewModel = db.KlientViewModels.Find(id);
            db.KlientViewModels.Remove(klientViewModel);
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
