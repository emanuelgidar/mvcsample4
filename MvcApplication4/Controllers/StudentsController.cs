using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication4.Models;

namespace MvcApplication4.Controllers
{   
    public class StudentsController : Controller
    {
        private Test context = new Test();

       
        //
        // GET: /Students/

        public ActionResult Index()
        {
            return View(context.Students.ToList());
        }

        //
        // GET: /Students/Details/5

        public ViewResult Details(int id)
        {
            Student student = context.Students.Single(x => x.StudentId == id);
            return View(student);
        }

        //
        // GET: /Students/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Students/Create

        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                context.Students.Add(student);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(student);
        }
        
        //
        // GET: /Students/Edit/5
 
        public ActionResult Edit(int id)
        {
            Student student = context.Students.Single(x => x.StudentId == id);
            return View(student);
        }

        //
        // POST: /Students/Edit/5

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                context.Entry(student).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        //
        // GET: /Students/Delete/5
 
        public ActionResult Delete(int id)
        {
            Student student = context.Students.Single(x => x.StudentId == id);
            return View(student);
        }

        //
        // POST: /Students/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Student student = context.Students.Single(x => x.StudentId == id);
            context.Students.Remove(student);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}