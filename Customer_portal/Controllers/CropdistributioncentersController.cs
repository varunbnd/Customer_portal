using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Customer_portal.Models;

namespace Customer_portal.Controllers
{
    public class CropdistributioncentersController : Controller
    {
        private UserdataEntities db = new UserdataEntities();

        // GET: Cropdistributioncenters
        public ActionResult Index()
        {
            return View(db.Cropdistributioncenters.ToList());
        }

        /* User View list*/

        public ActionResult Indexuserlist()
        {
            return View(db.Cropdistributioncenters.ToList());
        }

        /* */

        // GET: Cropdistributioncenters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cropdistributioncenter cropdistributioncenter = db.Cropdistributioncenters.Find(id);
            if (cropdistributioncenter == null)
            {
                return HttpNotFound();
            }
            return View(cropdistributioncenter);
        }

        // GET: Cropdistributioncenters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cropdistributioncenters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CropID,Cropname,Cropquantity,Croprate,Address")] Cropdistributioncenter cropdistributioncenter)
        {
            if (ModelState.IsValid)
            {
                db.Cropdistributioncenters.Add(cropdistributioncenter);
                db.SaveChanges();
                return Redirect("http://localhost:51766/Cropdistributioncenters/Indexuserlist");
            }

            return View(cropdistributioncenter);
        }

        // GET: Cropdistributioncenters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cropdistributioncenter cropdistributioncenter = db.Cropdistributioncenters.Find(id);
            if (cropdistributioncenter == null)
            {
                return HttpNotFound();
            }
            return View(cropdistributioncenter);
        }

        // POST: Cropdistributioncenters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CropID,Cropname,Cropquantity,Croprate,Address")] Cropdistributioncenter cropdistributioncenter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cropdistributioncenter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cropdistributioncenter);
        }

        // GET: Cropdistributioncenters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cropdistributioncenter cropdistributioncenter = db.Cropdistributioncenters.Find(id);
            if (cropdistributioncenter == null)
            {
                return HttpNotFound();
            }
            return View(cropdistributioncenter);
        }

        // POST: Cropdistributioncenters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cropdistributioncenter cropdistributioncenter = db.Cropdistributioncenters.Find(id);
            db.Cropdistributioncenters.Remove(cropdistributioncenter);
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
