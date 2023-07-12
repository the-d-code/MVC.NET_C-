using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Crud_Entity_Framework.Models;

namespace MVC_Crud_Entity_Framework.Controllers
{
    public class StudController : Controller
    {
        //
        // GET: /Stud/
        studydbEntities sm = new studydbEntities();
        public ActionResult Index()
        {
            
            List<Student > lst= sm.Students.ToList();
            return View(lst);
        }

        //
        // GET: /Stud/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Stud/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Stud/Create

        [HttpPost]
        public ActionResult Create(Student s)
        {
            try
            {
                sm.Students.AddObject(s);
                sm.SaveChanges();

                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Stud/Edit/5
 
        public ActionResult Edit(int id)
        {

            Student s=sm.Students.Single(ss => ss.rollno == id);
            return View(s);
        }

        //
        // POST: /Stud/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Student s)
        {
            try
            {
/*                Student ns = sm.Students.Single(ss => ss.rollno == id);

                ns.rollno = s.rollno;
                ns.sname = s.sname;
                ns.sem = s.sem;
                ns.course = s.course;*/
                UpdateModel(s);
                sm.SaveChanges();
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Stud/Delete/5
 
        public ActionResult Delete(int id)
        {
            Student s = sm.Students.Single(ss => ss.rollno == id);

            sm.DeleteObject(s);
            sm.SaveChanges();
            return RedirectToAction("Index");
            //Student s = sm.Students.Single(ss => ss.rollno == id);
            //return View(s);
        }

        //
        // POST: /Stud/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, Student st)
        {
            try
            {
                // TODO: Add delete logic here
                Student s = sm.Students.Single(ss => ss.rollno == id);

                sm.DeleteObject(s);
                sm.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
