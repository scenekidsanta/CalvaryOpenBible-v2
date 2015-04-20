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
    public class BeliefsController : Controller
    {
        private CalvaryContext db = new CalvaryContext();

        // GET: Beliefs
        public ActionResult Index()
        {
            return View(db.Belief.ToList());
        }

        // GET: Beliefs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Belief belief = db.Belief.Find(id);
            if (belief == null)
            {
                return HttpNotFound();
            }
            return View(belief);
        }

        // GET: Beliefs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Beliefs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BeliefID,BeliefTitle,BeliefDetails")] Belief belief)
        {
            if (ModelState.IsValid)
            {
                db.Belief.Add(belief);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(belief);
        }

        // GET: Beliefs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Belief belief = db.Belief.Find(id);
            if (belief == null)
            {
                return HttpNotFound();
            }
            return View(belief);
        }

        // POST: Beliefs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BeliefID,BeliefTitle,BeliefDetails")] Belief belief)
        {
            if (ModelState.IsValid)
            {
                db.Entry(belief).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(belief);
        }

        // GET: Beliefs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Belief belief = db.Belief.Find(id);
            if (belief == null)
            {
                return HttpNotFound();
            }
            return View(belief);
        }

        // POST: Beliefs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Belief belief = db.Belief.Find(id);
            db.Belief.Remove(belief);
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
