using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalPracise.Models;
namespace FinalPracise.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        FinalDataContext dc = new FinalDataContext();
        public ActionResult Index()
        {
            return View(dc.ProductTBs.ToList());
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
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
        public JsonResult getProduct(string pname)
        {
            var data = from m in dc.ProductTBs where m.ProductName.Contains(pname) select new {
                m.ProductName,
                m.CategoryTB.Categiry,
                m.MfgDate,
                m.Price,
                m.IsAvailable,
                m.ProductId,
               
            };
            return Json(new { result=data},JsonRequestBehavior.AllowGet);
        }

    }
}
