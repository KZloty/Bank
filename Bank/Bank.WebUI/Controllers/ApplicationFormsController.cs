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
    public class ApplicationFormsController : Controller
    {
        private BankWebUIContext db = new BankWebUIContext();

        // GET: ApplicationForms
        public ActionResult Index()
        {
            return View(db.ApplicationForms.ToList());
        }

        // GET: ApplicationForms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationForm applicationForm = db.ApplicationForms.Find(id);
            if (applicationForm == null)
            {
                return HttpNotFound();
            }
            return View(applicationForm);
        }

        // GET: ApplicationForms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ApplicationForms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ApplicationID,Imie,Nazwisko,PESEL,Miasto,KodPocztowy,Ulica,NumerDomu,NumerTelefonu")] ApplicationForm applicationForm)
        {
            if (ModelState.IsValid)
            {
                db.ApplicationForms.Add(applicationForm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(applicationForm);
        }

        // GET: ApplicationForms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationForm applicationForm = db.ApplicationForms.Find(id);
            if (applicationForm == null)
            {
                return HttpNotFound();
            }
            return View(applicationForm);
        }

        // POST: ApplicationForms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ApplicationID,Imie,Nazwisko,PESEL,Miasto,KodPocztowy,Ulica,NumerDomu,NumerTelefonu")] ApplicationForm applicationForm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(applicationForm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(applicationForm);
        }

        // GET: ApplicationForms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationForm applicationForm = db.ApplicationForms.Find(id);
            if (applicationForm == null)
            {
                return HttpNotFound();
            }
            return View(applicationForm);
        }

        // POST: ApplicationForms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ApplicationForm applicationForm = db.ApplicationForms.Find(id);
            db.ApplicationForms.Remove(applicationForm);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        // GET: Open Account
        public ActionResult Open(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationForm applicationForm = db.ApplicationForms.Find(id);
            Klient klient = new Klient() { Imie = applicationForm.Imie, Nazwisko = applicationForm.Nazwisko, PESEL = applicationForm.PESEL };
            Adres adres = new Adres() { Miasto = applicationForm.Miasto, KodPocztowy = applicationForm.KodPocztowy,
                                        Ulica = applicationForm.Ulica, NumerDomu = applicationForm.NumerDomu, Klient = klient };
            Telefon telefon = new Telefon() { NumerTelefonu = applicationForm.NumerTelefonu, Klient = klient };
            db.Klients.Add(klient);
            db.Adres.Add(adres);
            db.Telefons.Add(telefon);
            db.ApplicationForms.Remove(applicationForm);
            db.SaveChanges();

            if (applicationForm == null)
            {
                return HttpNotFound();
            }
            return View(applicationForm);
        }

        //// POST: Post open
        //[HttpPost, ActionName("Open")]
        //[ValidateAntiForgeryToken]
        //public ActionResult Open(int id)
        //{
        //    ApplicationForm applicationForm = db.ApplicationForms.Find(id);

        //    db.ApplicationForms.Remove(applicationForm);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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
