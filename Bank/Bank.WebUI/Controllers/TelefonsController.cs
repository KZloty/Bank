using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Bank.Entities;
using Bank.WebUI.Models;

namespace Bank.WebUI.Controllers
{
    public class TelefonsController : Controller
    {
        private BankWebUIContext db = new BankWebUIContext();

        // GET: Telefons
        public ActionResult Index()
        {
            var telefons = db.Telefons.Include(t => t.Klient);
            return View(telefons.ToList());
        }

        // GET: Telefons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Telefon telefon = db.Telefons.Find(id);
            if (telefon == null)
            {
                return HttpNotFound();
            }
            return View(telefon);
        }

        // GET: Telefons/Create
        public ActionResult Create()
        {
            ViewBag.KlientID = new SelectList(db.Klients, "KlientID", "Imie");
            return View();
        }

        // POST: Telefons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TelefonID,KlientID,NumerTelefonu")] Telefon telefon)
        {
            if (ModelState.IsValid)
            {
                db.Telefons.Add(telefon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.KlientID = new SelectList(db.Klients, "KlientID", "Imie", telefon.KlientID);
            return View(telefon);
        }

        // GET: Telefons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Telefon telefon = db.Telefons.Find(id);
            if (telefon == null)
            {
                return HttpNotFound();
            }
            ViewBag.KlientID = new SelectList(db.Klients, "KlientID", "Imie", telefon.KlientID);
            return View(telefon);
        }

        // POST: Telefons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TelefonID,KlientID,NumerTelefonu")] Telefon telefon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(telefon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.KlientID = new SelectList(db.Klients, "KlientID", "Imie", telefon.KlientID);
            return View(telefon);
        }

        // GET: Telefons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Telefon telefon = db.Telefons.Find(id);
            if (telefon == null)
            {
                return HttpNotFound();
            }
            return View(telefon);
        }

        // POST: Telefons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Telefon telefon = db.Telefons.Find(id);
            db.Telefons.Remove(telefon);
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
