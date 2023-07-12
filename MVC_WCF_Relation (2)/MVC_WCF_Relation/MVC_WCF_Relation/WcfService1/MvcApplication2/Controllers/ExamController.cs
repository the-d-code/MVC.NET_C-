using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.ServiceReference1;

namespace MvcApplication2.Controllers
{
    public class ExamController : Controller
    {
        //
        // GET: /Exam/
        CRUDServiceClient sc = new CRUDServiceClient();
        public ActionResult Index()
        {

            return View(sc.showallexam());
        }

        //
        // GET: /Exam/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Exam/Create
        public List<SelectListItem> getCity()
        {
            List<SelectListItem> mycity = new List<SelectListItem>() {  
        new SelectListItem {  
            Text = "Surat", Value = "1"  
        },  
        new SelectListItem {  
            Text = "Baroda", Value = "2"  
        },  
        new SelectListItem {  
            Text = "Pune", Value = "3"  
        },  
        new SelectListItem {  
            Text = "Manager", Value = "4"  
        }};
            return mycity;
        }
        public ActionResult Create()
        {
            List<SelectListItem> mystud = new List<SelectListItem>() ;
            foreach( var st in sc.showallstud ())
            {
                mystud.Add ( new SelectListItem {  
            Text = st.sname , Value =st.rno.ToString ()  });
            }
            ViewBag.city = mystud;
            return View();
        } 

        //
        // POST: /Exam/Create

        [HttpPost]
        public ActionResult Create(exam ee)
        {
            try
            {
                // TODO: Add insert logic here
            
                string msg=sc.InsertExam(ee);
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Exam/Edit/5
 
        public ActionResult Edit(int id)
        {
            List<SelectListItem> mystud = new List<SelectListItem>();
            
            exam e = sc.SearchExam(id);
            foreach (var st in sc.showallstud())
            {
                bool sel = false;
                if (st.rno == e.rno )
                    sel = true;

                mystud.Add(new SelectListItem
                {
                    Text = st.sname,
                    Value = st.rno.ToString(),
                    Selected = sel
                });
            }

            ViewBag.city = mystud;
            
            return View(e);
        }

        //
        // POST: /Exam/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, exam e)
        {
            try
            {
                // TODO: Add update logic here
                string msg=sc.UpdateExam(e);
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Exam/Delete/5
 
        public ActionResult Delete(int id)
        {
            exam e = sc.SearchExam(id);
            return View(e);
        }

        //
        // POST: /Exam/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                string msg = sc.DeleteExam(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
