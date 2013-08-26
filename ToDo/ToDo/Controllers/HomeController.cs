using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDo.Models;

namespace ToDo.Controllers
{
    public class HomeController : Controller
    {
        private ToDoContext db = new ToDoContext();

        //
        // GET: /Home/

        public ActionResult Index()
        {
            var todoList = from t in db.ToDoes
                           select t;
            return View(todoList.ToList());
        }

        //
        // GET: /Home/Details/5

        public ActionResult Details(int id = 0)
        {
            ToDoModels todomodels = db.ToDoes.Find(id);
            if (todomodels == null)
            {
                return HttpNotFound();
            }
            return View(todomodels);
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ToDoModels todomodels)
        {
            if (ModelState.IsValid)
            {
                db.ToDoes.Add(todomodels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(todomodels);
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ToDoModels todomodels = db.ToDoes.Find(id);
            if (todomodels == null)
            {
                return HttpNotFound();
            }
            return View(todomodels);
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ToDoModels todomodels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(todomodels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(todomodels);
        }

        //
        // GET: /Home/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ToDoModels todomodels = db.ToDoes.Find(id);
            if (todomodels == null)
            {
                return HttpNotFound();
            }
            return View(todomodels);
        }

        //
        // POST: /Home/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ToDoModels todomodels = db.ToDoes.Find(id);
            db.ToDoes.Remove(todomodels);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}