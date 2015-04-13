using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CalvaryOpebBibleWebsite.DAL;
using CalvaryOpebBibleWebsite.Models;

namespace CalvaryOpebBibleWebsite.Views
{
    public class PastorsController : Controller
    {
        private CalvaryContext db = new CalvaryContext();

        // GET: Pastors
        public ActionResult Index()
        {
            return View(db.Pastor.ToList());
        }

        // GET: Pastors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pastor pastor = db.Pastor.Find(id);
            if (pastor == null)
            {
                return HttpNotFound();
            }
            return View(pastor);
        }

        // GET: Pastors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pastors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PastorID,PastorName,Title,Details")] Pastor pastor)
        {
            if (ModelState.IsValid)
            {
                db.Pastor.Add(pastor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pastor);
        }

        // GET: Pastors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pastor pastor = db.Pastor.Find(id);
            if (pastor == null)
            {
                return HttpNotFound();
            }
            return View(pastor);
        }

        // POST: Pastors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PastorID,PastorName,Title,Details")] Pastor pastor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pastor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pastor);
        }

        // GET: Pastors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pastor pastor = db.Pastor.Find(id);
            if (pastor == null)
            {
                return HttpNotFound();
            }
            return View(pastor);
        }

        // POST: Pastors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pastor pastor = db.Pastor.Find(id);
            db.Pastor.Remove(pastor);
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
