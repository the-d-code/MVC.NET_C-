using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using Web_Service_MVC.localhost;
using Web_Service_MVC.Models;
namespace Web_Service_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        WebService1 wc = new WebService1();
        // GET: Employee
        public ActionResult Index()
        {
            
            return View(wc.getData());
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            
            return View(wc.FillEmployee(id));
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            var Department = wc.getDept();
            ViewBag.DepartmentList = new SelectList(Department, "DeptId", "DeptName");
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(EmpTB emp)
        {
            try
            {
                wc.InsertEmployee(emp);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            var Department = wc.getDept();
            var ids=wc.FillEmployee(id);
            ViewBag.DepartmentList = new SelectList(Department, "DeptId", "DeptName",ids.DeptId);
            return View(ids);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id,EmpTB objemps)
        {
            try
            {
               wc.EditEmployee(id, objemps);
               
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            wc.DeleteEmployee(id);

            return RedirectToAction("Index");
        }

        // POST: Employee/Delete/5
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
