using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;


namespace APIConsume.Controllers
{
    public class APIDEMOController : Controller
    {
        // GET: APIDEMO
        public ActionResult Index()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:51872/api/");
                //HTTP GET
                var responseTask = client.GetAsync("EmployeeTBs");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readdata = result.Content.ReadAsAsync<EmployeeTb[]>();
                    readdata.Wait();
                    var emp = readdata.Result;
                    return View(emp.ToList());
                }
                else
                {
                    return View();
                }

            }
        }
     
        // GET: APIDEMO/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: APIDEMO/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: APIDEMO/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: APIDEMO/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: APIDEMO/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: APIDEMO/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: APIDEMO/Delete/5
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