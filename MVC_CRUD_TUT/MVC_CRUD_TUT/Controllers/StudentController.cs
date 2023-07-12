using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_CRUD_TUT.Models;
namespace MVC_CRUD_TUT.Controllers
{
  


    public class StudentController : Controller
    {
        mvctosqlDataContext objdb = new mvctosqlDataContext();
        // GET: Student
        public ActionResult Index()
        {
            var data=from x in objdb.Students select x;
            return View(data.ToList());
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            //Student s = objdb.Students.SingleOrDefault(s1=>s1.Rno==id);
            var x = from s in objdb.Students where s.Rno == id select s;
            return View(x.First());
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(Student s)
        {
            try
            {
                // TODO: Add insert logic here
                objdb.Students.InsertOnSubmit(s);
                objdb.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            var s1 = objdb.Students.SingleOrDefault(s => s.Rno == id);

            return View(s1);
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Student s)
        {
            try
            {
                // TODO: Add update logic here
                var s1 = objdb.Students.SingleOrDefault(s2 => s2.Rno == id);
                UpdateModel(s1);
                objdb.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            //var s1= objdb.Students.SingleOrDefault(s => s.Rno == id);
            //return View(s1);
            var s1 = objdb.Students.SingleOrDefault(s2 => s2.Rno == id);
            objdb.Students.DeleteOnSubmit(s1);
            objdb.SubmitChanges();
            return RedirectToAction("Index");
            
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Student s)
        {
            try
            {
                // TODO: Add delete logic here
                //var s1 = objdb.Students.SingleOrDefault(s2 => s2.Rno == id);
                //objdb.Students.DeleteOnSubmit(s1);
                //objdb.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
