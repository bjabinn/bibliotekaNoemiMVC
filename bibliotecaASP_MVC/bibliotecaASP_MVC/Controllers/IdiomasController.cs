using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using bibliotecaASP_MVC;
using bibliotecaASP_MVC.Models;

namespace bibliotecaASP_MVC.Controllers
{
    public class IdiomasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Idiomas
        public ActionResult Index()
        {
            return View(db.TIdiomas.ToList());
        }

        // GET: Idiomas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TIdioma tIdioma = db.TIdiomas.Find(id);
            if (tIdioma == null)
            {
                return HttpNotFound();
            }
            return View(tIdioma);
        }

        // GET: Idiomas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Idiomas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Idioma")] TIdioma tIdioma)
        {
            if (ModelState.IsValid)
            {
                db.TIdiomas.Add(tIdioma);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tIdioma);
        }

        // GET: Idiomas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TIdioma tIdioma = db.TIdiomas.Find(id);
            if (tIdioma == null)
            {
                return HttpNotFound();
            }
            return View(tIdioma);
        }

        // POST: Idiomas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Idioma")] TIdioma tIdioma)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tIdioma).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tIdioma);
        }

        // GET: Idiomas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TIdioma tIdioma = db.TIdiomas.Find(id);
            if (tIdioma == null)
            {
                return HttpNotFound();
            }
            return View(tIdioma);
        }

        // POST: Idiomas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            TIdioma tIdioma = db.TIdiomas.Find(id);
            db.TIdiomas.Remove(tIdioma);
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
