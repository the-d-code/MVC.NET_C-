using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pracise1.Models;

namespace Consumer.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            IEnumerable<EmployeeTb> students = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:56768/api/");
                //HTTP GET
                var responseTask = client.GetAsync("EmployeeTbs");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<EmployeeTb>>();
                    // JsonConvert.DeserializeObject<List<RetrieveMultipleResponse>>(JsonStr);
               //   var ans=  JsonConvert.DeserializeObject(readTask);
                    readTask.Wait();

                    students = (readTask.Result);
                }
                else //web api sent error response 
                {
                    //log response status here..

                    students = Enumerable.Empty<EmployeeTb>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(students);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeTb Emp)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:56768/api/EmployeeTbs");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<EmployeeTb>("EmployeeTbs", Emp);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(Emp);
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            EmployeeTb Emp = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:56768/api/");
                //HTTP GET
                var responseTask = client.GetAsync("EmployeeTbs?id=" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<EmployeeTb>();
                    readTask.Wait();

                    Emp = readTask.Result;
                }
            }
            return View(Emp);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmployeeTb Emp)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:56768/api/EmployeeTbs");

                //HTTP POST
                var putTask = client.PutAsJsonAsync<EmployeeTb>("EmployeeTbs", Emp);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }
            return View(Emp);
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
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