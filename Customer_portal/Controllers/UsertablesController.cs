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
    public class UsertablesController : Controller
    {
        private UserdataEntities db = new UserdataEntities();

        // GET: Usertables
        public ActionResult Index()
        {
            return View(db.Usertables.ToList());
        }



        // GET: Usertables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usertable usertable = db.Usertables.Find(id);
            if (usertable == null)
            {
                return HttpNotFound();
            }
            return View(usertable);
        }

        // GET: Usertables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usertables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserID,EmailAddress,Password,ConfirmPassword,PhoneNumber")] Usertable usertable)
        {
            if (ModelState.IsValid)
            {
                db.Usertables.Add(usertable);
                db.SaveChanges();
                return Redirect("http://localhost:51766/WelcomePage.aspx");
            }

            return View(usertable);
        }

        // GET: Usertables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usertable usertable = db.Usertables.Find(id);
            if (usertable == null)
            {
                return HttpNotFound();
            }
            return View(usertable);
        }

        // POST: Usertables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserID,EmailAddress,Password,ConfirmPassword,PhoneNumber")] Usertable usertable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usertable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usertable);
        }

        // GET: Usertables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usertable usertable = db.Usertables.Find(id);
            if (usertable == null)
            {
                return HttpNotFound();
            }
            return View(usertable);
        }

        // POST: Usertables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Usertable usertable = db.Usertables.Find(id);
            db.Usertables.Remove(usertable);
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


        /*User login*/

        UserdataEntities UserDB = new UserdataEntities();
        public ActionResult UserLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserLogin(Usertable usertable)
        {
            using (var context = new UserdataEntities())
            {
                bool isValid = context.Usertables.Any(x => x.EmailAddress == usertable.EmailAddress && x.Password == usertable.Password);
                if (isValid)
                {
                    Session["name"] = usertable.EmailAddress;
                    Session["role"] = "Userlogin";
                    return Redirect("http://localhost:51766/WelcomePage.aspx");
                }
                ModelState.AddModelError("", "Invalid Email Address and Password");
                return View();
            }
        }



        /* */

        /*Admin Login */

        UserdataEntities admindb = new UserdataEntities();
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(Admintable admintable)
        {
            using (var context = new UserdataEntities())
            {
                bool isValid = context.Admintables.Any(x => x.Name == admintable.Name && x.Password == admintable.Password);
                if (isValid)
                {
                    Session["name"] = admintable.Name;
                    Session["role"] = "admin";
                    return Redirect("http://localhost:51766/Usertables/Index");
                }
                ModelState.AddModelError("", "Invalid Admin name and Password");
                return View();
            }
        }
    }
}
