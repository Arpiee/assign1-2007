using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using assignment.Models;

namespace assignment.Controllers
{
    public class aeroplanesController : Controller
    {
        private Model1 db = new Model1();

        // GET: aeroplanes
        public ActionResult Index()
        {
            return View(db.aeroplanes.ToList());
        }

        // GET: aeroplanes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            aeroplane aeroplane = db.aeroplanes.Find(id);
            if (aeroplane == null)
            {
                return HttpNotFound();
            }
            return View(aeroplane);
        }

        // GET: aeroplanes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: aeroplanes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "planes,company,price")] aeroplane aeroplane)
        {
            if (ModelState.IsValid)
            {
                db.aeroplanes.Add(aeroplane);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aeroplane);
        }

        // GET: aeroplanes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            aeroplane aeroplane = db.aeroplanes.Find(id);
            if (aeroplane == null)
            {
                return HttpNotFound();
            }
            return View(aeroplane);
        }

        // POST: aeroplanes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "planes,company,price")] aeroplane aeroplane)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aeroplane).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aeroplane);
        }

        // GET: aeroplanes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            aeroplane aeroplane = db.aeroplanes.Find(id);
            if (aeroplane == null)
            {
                return HttpNotFound();
            }
            return View(aeroplane);
        }

        // POST: aeroplanes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            aeroplane aeroplane = db.aeroplanes.Find(id);
            db.aeroplanes.Remove(aeroplane);
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
