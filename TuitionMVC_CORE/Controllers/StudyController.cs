using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TuitionMVC_CORE.Controllers
{
    public class StudyController : Controller
    {
        // GET: Study
        public ActionResult Index()
        {
            ViewBag.hello = "Welcome Shubham";
            return View();
        }

        public IActionResult calc()
        {
            return View();
        }
        [HttpPost]
        public IActionResult calc(IFormCollection f)
        {
             int v = Convert.ToInt32(f["length"].ToString())*Convert.ToInt32(f["breath"].ToString())*Convert.ToInt32(f["height"].ToString());
            //Convert.ToString(f["volume"]) = v.ToString();
            ViewBag.volume = v;
            int a = (2 * Convert.ToInt32(f["length"].ToString()) * Convert.ToInt32(f["breath"].ToString())) + (2 * Convert.ToInt32(f["height"].ToString()) * Convert.ToInt32(f["breath"].ToString())) + (2 * Convert.ToInt32(f["length"].ToString()) * Convert.ToInt32(f["height"].ToString()));
            ViewBag.area = a;
            return View();
        }

        // GET: Study/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Study/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Study/Create
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

        // GET: Study/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Study/Edit/5
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

        // GET: Study/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Study/Delete/5
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