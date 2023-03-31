using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_CRUD_TUT.Models;

namespace MVC_CRUD_TUT.Controllers
{
    public class ExamController : Controller
    {
        mvctosqlDataContext objexam = new mvctosqlDataContext();

        // GET: Exam
        public ActionResult Index()
        {
            return View(objexam.ExamTBs.ToList());
        }

        // GET: Exam/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Exam/Create
        public ActionResult Create()
        {
            var studentList = objexam.Students.ToList();
            ViewBag.StudentList = new SelectList(studentList,"Rno","Name");

            return View();
        }

        // POST: Exam/Create
        [HttpPost]
        public ActionResult Create(ExamTB e)
        {
            try
            {
               
                // TODO: Add insert logic here
                objexam.ExamTBs.InsertOnSubmit(e);
                objexam.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Exam/Edit/5
        public ActionResult Edit(int id)
        {
            var editdata = objexam.ExamTBs.SingleOrDefault(e => e.Id == id);
            var studentList = objexam.Students.ToList();
            ViewBag.StudentList = new SelectList(studentList, "Rno", "Name",editdata.Rno);
            return View(editdata);
        }

        // POST: Exam/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ExamTB e)
        {
            try
            {
                var editdata = objexam.ExamTBs.SingleOrDefault(ee => ee.Id == id);

                UpdateModel(editdata);
                objexam.SubmitChanges();


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Exam/Delete/5
        public ActionResult Delete(int id)
        {
            var data = objexam.ExamTBs.SingleOrDefault(s => s.Id == id);
            objexam.ExamTBs.DeleteOnSubmit(data);
            objexam.SubmitChanges();
            return View();
        }

        // POST: Exam/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
