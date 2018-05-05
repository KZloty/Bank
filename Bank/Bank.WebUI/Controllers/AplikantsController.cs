using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Bank.Domain.Entities;
using Bank.WebUI.Models;

namespace Bank.WebUI.Controllers
{
    public class AplikantsController : Controller
    {
        private AplikantDbContext db = new AplikantDbContext();

        // GET: Aplikants
        public ActionResult Index()
        {
            return View(db.Aplikants.ToList());
        }

        // GET: Aplikants/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aplikant aplikant = db.Aplikants.Find(id);
            if (aplikant == null)
            {
                return HttpNotFound();
            }
            return View(aplikant);
        }

        // GET: Aplikants/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Aplikants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AplikantID,Imie,Nazwisko,PESEL")] Aplikant aplikant)
        {
            if (ModelState.IsValid)
            {
                db.Aplikants.Add(aplikant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aplikant);
        }

        // GET: Aplikants/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aplikant aplikant = db.Aplikants.Find(id);
            if (aplikant == null)
            {
                return HttpNotFound();
            }
            return View(aplikant);
        }

        // POST: Aplikants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AplikantID,Imie,Nazwisko,PESEL")] Aplikant aplikant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aplikant).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aplikant);
        }

        // GET: Aplikants/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aplikant aplikant = db.Aplikants.Find(id);
            if (aplikant == null)
            {
                return HttpNotFound();
            }
            return View(aplikant);
        }

        // POST: Aplikants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Aplikant aplikant = db.Aplikants.Find(id);
            db.Aplikants.Remove(aplikant);
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
