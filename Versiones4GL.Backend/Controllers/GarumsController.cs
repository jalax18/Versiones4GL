using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Versiones4GL.Backend.Models;
using Versiones4GL.Common.Models;

namespace Versiones4GL.Backend.Controllers
{
    public class GarumsController : Controller
    {
        private LocalDataContext db = new LocalDataContext();

        // GET: Garums
        public ActionResult Index()
        {
            return View(db.Garums.ToList());
        }

        // GET: Garums/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Garum garum = db.Garums.Find(id);
            if (garum == null)
            {
                return HttpNotFound();
            }
            return View(garum);
        }

        // GET: Garums/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Garums/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GarumId,VerGarum")] Garum garum)
        {
            if (ModelState.IsValid)
            {
                db.Garums.Add(garum);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(garum);
        }

        // GET: Garums/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Garum garum = db.Garums.Find(id);
            if (garum == null)
            {
                return HttpNotFound();
            }
            return View(garum);
        }

        // POST: Garums/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GarumId,VerGarum")] Garum garum)
        {
            if (ModelState.IsValid)
            {
                db.Entry(garum).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(garum);
        }

        // GET: Garums/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Garum garum = db.Garums.Find(id);
            if (garum == null)
            {
                return HttpNotFound();
            }
            return View(garum);
        }

        // POST: Garums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Garum garum = db.Garums.Find(id);
            db.Garums.Remove(garum);
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
