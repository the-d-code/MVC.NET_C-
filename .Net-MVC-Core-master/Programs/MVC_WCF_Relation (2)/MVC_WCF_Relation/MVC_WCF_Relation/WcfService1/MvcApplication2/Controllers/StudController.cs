using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.ServiceReference1;

namespace MvcApplication2.Controllers
{
    public class StudController : Controller
    {
        //
        // GET: /Stud/
        CRUDServiceClient sc = new CRUDServiceClient();
        public ActionResult Index()
        {
            
            
           
            
            return View(sc.showallstud());
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
        public ActionResult Create(stud s)
        {
            try
            {
                string msg=sc.InsertStud(s);
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
            try
            {
                stud s = sc.SearchStud(id);
                // TODO: Add insert logic here

                return View(s);
            }
            catch
            {
                return View();
            }
        }

        //
        // POST: /Stud/Edit/5

        [HttpPost]
        public ActionResult Edit(int id,stud s)
        {
            try
            {
                // TODO: Add update logic here
                string msg = sc.UpdateStud(s);
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
            try
            {
                stud s = sc.SearchStud(id);
                // TODO: Add insert logic here

                return View(s);
            }
            catch
            {
                return View();
            }
        }

        //
        // POST: /Stud/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, stud s)
        {
            try
            {
                
                 string msg=sc.DeleteStud(id );
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
