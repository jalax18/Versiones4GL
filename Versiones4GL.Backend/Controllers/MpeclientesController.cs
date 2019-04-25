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
    public class MpeclientesController : Controller
    {
        private LocalDataContext db = new LocalDataContext();

        // GET: Mpeclientes
        public ActionResult Index()
        {
            return View(db.Mpeclientes.ToList());
        }

        // GET: Mpeclientes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mpecliente mpecliente = db.Mpeclientes.Find(id);
            if (mpecliente == null)
            {
                return HttpNotFound();
            }
            return View(mpecliente);
        }

        // GET: Mpeclientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mpeclientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MpeclienteId,VerMpecliente")] Mpecliente mpecliente)
        {
            if (ModelState.IsValid)
            {
                db.Mpeclientes.Add(mpecliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mpecliente);
        }

        // GET: Mpeclientes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mpecliente mpecliente = db.Mpeclientes.Find(id);
            if (mpecliente == null)
            {
                return HttpNotFound();
            }
            return View(mpecliente);
        }

        // POST: Mpeclientes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MpeclienteId,VerMpecliente")] Mpecliente mpecliente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mpecliente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mpecliente);
        }

        // GET: Mpeclientes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mpecliente mpecliente = db.Mpeclientes.Find(id);
            if (mpecliente == null)
            {
                return HttpNotFound();
            }
            return View(mpecliente);
        }

        // POST: Mpeclientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mpecliente mpecliente = db.Mpeclientes.Find(id);
            db.Mpeclientes.Remove(mpecliente);
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
