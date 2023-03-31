using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using practice.Models;

namespace crud.Controllers
{
    public class crudController : Controller
    {
        // GET: crud
        public ActionResult Index()
        {
            IEnumerable<Salary_Empptb> salary1 = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44376/api/");
                //HTTP GET
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
               // ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12| SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                var responseTask = client.GetAsync("Salarytbs");
               // client.DefaultRequestHeaders.Add("Connection", "Keep-Alive");
               // client.DefaultRequestHeaders.Add("Keep-Alive", "9600");
                // client.g
             
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                   var readTask = result.Content.ReadAsAsync<IList<Salary_Empptb>>();
                    readTask.Wait();


                 //   var res = result.Content.ReadAsStringAsync();
                    //var data=JsonConvert.DeserializeObject<IEnumerable<Salarytb>>(res.Result);

                    salary1 = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    salary1 = Enumerable.Empty<Salary_Empptb>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(salary1);
        }

        // GET: crud/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: crud/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: crud/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Salarytb salary1)
        {
          
                // TODO: Add insert logic here
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44376/api/");

                    //HTTP POST
                    var postTask = client.PostAsJsonAsync<Salarytb>("Salarytbs", salary1);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }

                ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
                return View(salary1);
            }

        // GET: crud/Edit/5
        public ActionResult Edit(int id)
        {
            Salarytb salary1 = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44376/api/");
                //HTTP GET
                var responseTask = client.GetAsync("Salarytbs/" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Salarytb>();
                    readTask.Wait();

                    salary1 = readTask.Result;
                }
            }

            return View(salary1);
        }

        // POST: crud/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Salarytb salary1)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44376/api" );
                salary1.Eid = 1;
                //HTTP POST
                var putTask = client.PutAsJsonAsync<Salarytb>("api/Salarytbs"+"/"+ salary1.Sid  , salary1);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }
            return View(salary1);

            
            }

        // GET: crud/Delete/5
        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44376/api/");

                //HTTP DELETE
                var deleteTask = client.DeleteAsync("Salarytbs/" + id.ToString());
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }

            return RedirectToAction("Index");
           
        }

        // POST: crud/Delete/5
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