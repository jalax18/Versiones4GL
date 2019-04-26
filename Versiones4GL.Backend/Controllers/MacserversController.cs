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
    public class MacserversController : Controller
    {
        private LocalDataContext db = new LocalDataContext();

        // GET: Macservers //
        public ActionResult Index()
        {
            return View(db.Macservers.ToList());
        }

        // GET: Macservers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Macserver macserver = db.Macservers.Find(id);
            if (macserver == null)
            {
                return HttpNotFound();
            }
            return View(macserver);
        }

        // GET: Macservers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Macservers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MacserverId,VerMacserver")] Macserver macserver)
        {
            if (ModelState.IsValid)
            {
                db.Macservers.Add(macserver);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(macserver);
        }

        // GET: Macservers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Macserver macserver = db.Macservers.Find(id);
            if (macserver == null)
            {
                return HttpNotFound();
            }
            return View(macserver);
        }

        // POST: Macservers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MacserverId,VerMacserver")] Macserver macserver)
        {
            if (ModelState.IsValid)
            {
                db.Entry(macserver).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(macserver);
        }

        // GET: Macservers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Macserver macserver = db.Macservers.Find(id);
            if (macserver == null)
            {
                return HttpNotFound();
            }
            return View(macserver);
        }

        // POST: Macservers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Macserver macserver = db.Macservers.Find(id);
            db.Macservers.Remove(macserver);
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
