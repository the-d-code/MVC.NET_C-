using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LastPracitse.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LastPracitse.Controllers
{
    
    public class EmployeeController : Controller
    {
        EmployeeContext dc = new EmployeeContext();
        // GET: Employee
        public ActionResult Index()
        {
            var Employeedata = dc.EmployeeTb.ToList();
            foreach(var item in Employeedata)
            {
                item.Department = dc.DepartmentTb.Where(s => s.DepartmentId == item.DepartmentId).FirstOrDefault();
            }

            return View(Employeedata);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            var data = dc.DepartmentTb.ToList();
            ViewBag.Dept = new SelectList(data, "DepartmentId", "Department");
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                EmployeeTb emp = new EmployeeTb();
                emp.DepartmentId =Convert.ToInt32( collection["DepartmentId"]);
                emp.Name = collection["Name"];
                emp.Salary =Convert.ToInt64( collection["Salary"]);
                emp.Gender = collection["gender"];

                dc.EmployeeTb.Add(emp);
                dc.SaveChanges();

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

            var EmpData = dc.EmployeeTb.Find(id);
            var data = dc.DepartmentTb.ToList();
            ViewBag.Dept = new SelectList(data, "DepartmentId", "Department",EmpData.DepartmentId);
            return View(EmpData);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var Empdata = dc.EmployeeTb.Find(id);
                Empdata.DepartmentId = Convert.ToInt32(collection["DepartmentId"]);
                Empdata.Name = collection["Name"];
                Empdata.Salary = Convert.ToInt32(collection["Salary"]);
                Empdata.Gender = collection["gender"];

                TryUpdateModelAsync(Empdata);
                dc.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            var data = dc.EmployeeTb.Find(id);
            dc.EmployeeTb.Remove(data);
            dc.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST: Employee/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public JsonResult GetEmp(string name)
        {
            var data = from m in dc.EmployeeTb
                       where m.Name.Contains(name)
                       select new
                       {
                           m.Name,
                           m.Salary,
                           m.Gender,
                           m.Department.Department,
                           m.EmployeeId,

                       };
            return Json(new { result = data });

        }
    }
}