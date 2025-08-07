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
    public class SoiltypetablesController : Controller
    {
        private UserdataEntities db = new UserdataEntities();

        // GET: Soiltypetables
        public ActionResult Index()
        {
            return View(db.Soiltypetables.ToList());
        }

        /* user soil type view*/

        public ActionResult Indexuserview()
        {
            return View(db.Soiltypetables.ToList());
        }

        // GET: Soiltypetables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Soiltypetable soiltypetable = db.Soiltypetables.Find(id);
            if (soiltypetable == null)
            {
                return HttpNotFound();
            }
            return View(soiltypetable);
        }

        // GET: Soiltypetables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Soiltypetables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SoilID,SoilType,Process1,Process2")] Soiltypetable soiltypetable)
        {
            if (ModelState.IsValid)
            {
                db.Soiltypetables.Add(soiltypetable);
                db.SaveChanges();
                return Redirect("http://localhost:51766/Soiltypetables/Indexuserview");
            }

            return View(soiltypetable);
        }

        // GET: Soiltypetables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Soiltypetable soiltypetable = db.Soiltypetables.Find(id);
            if (soiltypetable == null)
            {
                return HttpNotFound();
            }
            return View(soiltypetable);
        }

        // POST: Soiltypetables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SoilID,SoilType,Process1,Process2")] Soiltypetable soiltypetable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(soiltypetable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(soiltypetable);
        }

        // GET: Soiltypetables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Soiltypetable soiltypetable = db.Soiltypetables.Find(id);
            if (soiltypetable == null)
            {
                return HttpNotFound();
            }
            return View(soiltypetable);
        }

        // POST: Soiltypetables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Soiltypetable soiltypetable = db.Soiltypetables.Find(id);
            db.Soiltypetables.Remove(soiltypetable);
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
