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
    public class MacclientesController : Controller
    {
        private LocalDataContext db = new LocalDataContext();

        // GET: Macclientes
        public ActionResult Index()
        {
            return View(db.Macclientes.ToList());
        }

        // GET: Macclientes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Maccliente maccliente = db.Macclientes.Find(id);
            if (maccliente == null)
            {
                return HttpNotFound();
            }
            return View(maccliente);
        }

        // GET: Macclientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Macclientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MacclienteId,VerMaccliente")] Maccliente maccliente)
        {
            if (ModelState.IsValid)
            {
                db.Macclientes.Add(maccliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(maccliente);
        }

        // GET: Macclientes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Maccliente maccliente = db.Macclientes.Find(id);
            if (maccliente == null)
            {
                return HttpNotFound();
            }
            return View(maccliente);
        }

        // POST: Macclientes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MacclienteId,VerMaccliente")] Maccliente maccliente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(maccliente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(maccliente);
        }

        // GET: Macclientes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Maccliente maccliente = db.Macclientes.Find(id);
            if (maccliente == null)
            {
                return HttpNotFound();
            }
            return View(maccliente);
        }

        // POST: Macclientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Maccliente maccliente = db.Macclientes.Find(id);
            db.Macclientes.Remove(maccliente);
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
