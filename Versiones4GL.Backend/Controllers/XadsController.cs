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
    public class XadsController : Controller
    {
        private LocalDataContext db = new LocalDataContext();

        // GET: Xads
        public ActionResult Index()
        {
            return View(db.Xads.ToList());
        }

        // GET: Xads/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Xad xad = db.Xads.Find(id);
            if (xad == null)
            {
                return HttpNotFound();
            }
            return View(xad);
        }

        // GET: Xads/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Xads/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "XadId,VerXad")] Xad xad)
        {
            if (ModelState.IsValid)
            {
                db.Xads.Add(xad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(xad);
        }

        // GET: Xads/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Xad xad = db.Xads.Find(id);
            if (xad == null)
            {
                return HttpNotFound();
            }
            return View(xad);
        }

        // POST: Xads/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "XadId,VerXad")] Xad xad)
        {
            if (ModelState.IsValid)
            {
                db.Entry(xad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(xad);
        }

        // GET: Xads/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Xad xad = db.Xads.Find(id);
            if (xad == null)
            {
                return HttpNotFound();
            }
            return View(xad);
        }

        // POST: Xads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Xad xad = db.Xads.Find(id);
            db.Xads.Remove(xad);
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
