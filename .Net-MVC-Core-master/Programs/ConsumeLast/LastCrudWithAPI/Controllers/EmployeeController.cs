using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ConsumeLast.Models;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LastCrudWithAPI.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            IEnumerable <EmpDept> Emplist= null;
            using (var client=new HttpClient())
            {
                client.BaseAddress =new Uri("http://localhost:64051/api/");
                var responsetask = client.GetAsync("EmployeeTbs");
                responsetask.Wait();

                var resulttask = responsetask.Result;
                if (resulttask.IsSuccessStatusCode)
                {
                    var readtask = resulttask.Content.ReadAsAsync<IList<EmpDept>>();
                    readtask.Wait();
                    Emplist = readtask.Result;
                }


            }
                return View(Emplist);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            IEnumerable<DepartmentTb> Dept = null;
            using (var client=new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:64051/api/");
                var response = client.GetAsync("DepartmentTbs");
                response.Wait();
                var result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readtask = result.Content.ReadAsAsync<IList<DepartmentTb>>();
                    readtask.Wait();
                    Dept = readtask.Result;
                }
            }
            ViewBag.Dept = new SelectList(Dept, "DepartmentId", "Department");

                return View();
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeTb Emp)
        {
            try
            {
                using (var client=new HttpClient())
                {
                    client.BaseAddress=new Uri("http://localhost:64051/api/");

                    var posttask = client.PostAsJsonAsync<EmployeeTb>("EmployeeTbs", Emp);
                    posttask.Wait();
                    var result = posttask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }

                    return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            EmployeeTb Emp = null;
            using (var client=new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:64051/api/");
                var editdata = client.GetAsync("EmployeeTbs/" + id);
                editdata.Wait();
                var result = editdata.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readdata = result.Content.ReadAsAsync<EmployeeTb>();
                    readdata.Wait();
                    Emp = readdata.Result;
                }
            }
            IEnumerable<DepartmentTb> Dept = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:64051/api/");
                var response = client.GetAsync("DepartmentTbs");
                response.Wait();
                var result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readtask = result.Content.ReadAsAsync<IList<DepartmentTb>>();
                    readtask.Wait();
                    Dept = readtask.Result;
                }
            }
            ViewBag.Dept = new SelectList(Dept, "DepartmentId", "Department",Emp.DepartmentId);
            return View(Emp);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,EmployeeTb Emp)
        {
            try
            {
                using (var client=new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:64051/api/");
                    var puttask = client.PutAsJsonAsync("EmployeeTbs/"+id,Emp);
                    puttask.Wait();
                    var result = puttask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }


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
            
            using(var client=new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:64051/api/");
                var deletetask = client.DeleteAsync("EmployeeTbs/" + id);
                deletetask.Wait();
                var result = deletetask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }

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
    }
}