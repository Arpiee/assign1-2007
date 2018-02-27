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
    public class HelicoptersController : Controller
    {
        private Model1 db = new Model1();

        // GET: Helicopters
        public ActionResult Index()
        {
            return View(db.Helicopters.ToList());
        }

        // GET: Helicopters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Helicopter helicopter = db.Helicopters.Find(id);
            if (helicopter == null)
            {
                return HttpNotFound();
            }
            return View(helicopter);
        }

        // GET: Helicopters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Helicopters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Price,Helicopters,Model_Name,Purpose")] Helicopter helicopter)
        {
            if (ModelState.IsValid)
            {
                db.Helicopters.Add(helicopter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(helicopter);
        }

        // GET: Helicopters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Helicopter helicopter = db.Helicopters.Find(id);
            if (helicopter == null)
            {
                return HttpNotFound();
            }
            return View(helicopter);
        }

        // POST: Helicopters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Price,Helicopters,Model_Name,Purpose")] Helicopter helicopter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(helicopter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(helicopter);
        }

        // GET: Helicopters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Helicopter helicopter = db.Helicopters.Find(id);
            if (helicopter == null)
            {
                return HttpNotFound();
            }
            return View(helicopter);
        }

        // POST: Helicopters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Helicopter helicopter = db.Helicopters.Find(id);
            db.Helicopters.Remove(helicopter);
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
