using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Versiones4GL.Backend.Models;
using Versiones4GL.Common.Models;

namespace Versiones4GL.Backend.Controllers
{
    public class StationsController : Controller
    {
        private LocalDataContext db = new LocalDataContext();

        // GET: Stations
        public async Task<ActionResult> Index()
        {
            var stations = db.Stations.Include(s => s.Garum).Include(s => s.Maccliente).Include(s => s.Macserver).Include(s => s.Mpeccliente).Include(s => s.Province).Include(s => s.Xad);
            return View(await stations.ToListAsync());
        }

        // GET: Stations/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Station station = await db.Stations.FindAsync(id);
            if (station == null)
            {
                return HttpNotFound();
            }
            return View(station);
        }

        // GET: Stations/Create
        public ActionResult Create()
        {
            ViewBag.GarumId = new SelectList(db.Garums, "GarumId", "Version");
            ViewBag.MacclienteId = new SelectList(db.Macclientes, "MacclienteId", "Version");
            ViewBag.MacserverId = new SelectList(db.Macservers, "MacserverId", "Version");
            ViewBag.MpeclienteId = new SelectList(db.Mpeclientes, "MpeclienteId", "Version");
            ViewBag.ProvinceId = new SelectList(db.Provinces, "ProvinceId", "Name");
            ViewBag.XadId = new SelectList(db.Xads, "XadId", "Version");
            return View();
        }

        // POST: Stations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "StationId,NameStation,ProvinceId,MacserverId,MacclienteId,MpeclienteId,XadId,GarumId")] Station station)
        {
            if (ModelState.IsValid)
            {
                db.Stations.Add(station);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.GarumId = new SelectList(db.Garums, "GarumId", "Version", station.GarumId);
            ViewBag.MacclienteId = new SelectList(db.Macclientes, "MacclienteId", "Version", station.MacclienteId);
            ViewBag.MacserverId = new SelectList(db.Macservers, "MacserverId", "Version", station.MacserverId);
            ViewBag.MpeclienteId = new SelectList(db.Mpeclientes, "MpeclienteId", "Version", station.MpeclienteId);
            ViewBag.ProvinceId = new SelectList(db.Provinces, "ProvinceId", "Name", station.ProvinceId);
            ViewBag.XadId = new SelectList(db.Xads, "XadId", "Version", station.XadId);
            return View(station);
        }

        // GET: Stations/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Station station = await db.Stations.FindAsync(id);
            if (station == null)
            {
                return HttpNotFound();
            }
            ViewBag.GarumId = new SelectList(db.Garums, "GarumId", "Version", station.GarumId);
            ViewBag.MacclienteId = new SelectList(db.Macclientes, "MacclienteId", "Version", station.MacclienteId);
            ViewBag.MacserverId = new SelectList(db.Macservers, "MacserverId", "Version", station.MacserverId);
            ViewBag.MpeclienteId = new SelectList(db.Mpeclientes, "MpeclienteId", "Version", station.MpeclienteId);
            ViewBag.ProvinceId = new SelectList(db.Provinces, "ProvinceId", "Name", station.ProvinceId);
            ViewBag.XadId = new SelectList(db.Xads, "XadId", "Version", station.XadId);
            return View(station);
        }

        // POST: Stations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "StationId,NameStation,ProvinceId,MacserverId,MacclienteId,MpeclienteId,XadId,GarumId")] Station station)
        {
            if (ModelState.IsValid)
            {
                db.Entry(station).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.GarumId = new SelectList(db.Garums, "GarumId", "Version", station.GarumId);
            ViewBag.MacclienteId = new SelectList(db.Macclientes, "MacclienteId", "Version", station.MacclienteId);
            ViewBag.MacserverId = new SelectList(db.Macservers, "MacserverId", "Version", station.MacserverId);
            ViewBag.MpeclienteId = new SelectList(db.Mpeclientes, "MpeclienteId", "Version", station.MpeclienteId);
            ViewBag.ProvinceId = new SelectList(db.Provinces, "ProvinceId", "Name", station.ProvinceId);
            ViewBag.XadId = new SelectList(db.Xads, "XadId", "Version", station.XadId);
            return View(station);
        }

        // GET: Stations/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Station station = await db.Stations.FindAsync(id);
            if (station == null)
            {
                return HttpNotFound();
            }
            return View(station);
        }

        // POST: Stations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Station station = await db.Stations.FindAsync(id);
            db.Stations.Remove(station);
            await db.SaveChangesAsync();
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
