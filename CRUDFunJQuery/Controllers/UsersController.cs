using CRUDFunJQuery.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDFunJQuery.Controllers
{
    public class UsersController : Controller
    {
        private DataContext db = new DataContext();

        // GET: /User/
        public ActionResult Index()
        {
            //@TempData["msg"] = "Helloo From KM...!!";

            return View(db.Users.ToList());
        }

        // GET: /User/Details/5
        public ActionResult Details(int id = 0)
        {
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: /User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user, string Command)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                TempData["Msg"] = "Data has been saved succeessfully";
                return RedirectToAction("Index");
            }

            return View(user);
        }

        // GET: /User/Edit/5
        public ActionResult Edit(int id = 0)
        {
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: /User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Msg"] = "Data has been updated succeessfully";
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: /User/Delete/5
        public ActionResult Delete(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
            TempData["Msg"] = "Data has been deleted succeessfully";
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
