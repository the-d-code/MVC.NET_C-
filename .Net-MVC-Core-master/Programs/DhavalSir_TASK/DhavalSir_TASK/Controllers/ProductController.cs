using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DhavalSir_TASK.Models;
namespace DhavalSir_TASK.Controllers
{
    
    public class ProductController : Controller
    {
        ProductsDataContext objProduct = new ProductsDataContext();

        // GET: Product
        public ActionResult Index()
        {
            
            return View(objProduct.ProductsTBs.ToList());
        }
        [HttpPost]
        public ActionResult Index(string name)
        {
            var q = from x in objProduct.ProductsTBs where x.ProductName.Contains(name) select x;

            return View(q.ToList());
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var s1 = objProduct.ProductsTBs.SingleOrDefault(s => s.ProductId == id);
            return View(s1);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(ProductsTB NewProduct)
        {
            try
            {
                // TODO: Add insert logic here
                objProduct.ProductsTBs.InsertOnSubmit(NewProduct);
                objProduct.SubmitChanges();
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
            var s1 = objProduct.ProductsTBs.SingleOrDefault(s => s.ProductId == id);
            return View(s1);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ProductsTB NewProduct)
        {
            try
            {
                var s1 = objProduct.ProductsTBs.SingleOrDefault(s2 => s2.ProductId == id);
                s1.ProductName = NewProduct.ProductName;
                s1.Price = NewProduct.Price;
                s1.Quantity = NewProduct.Quantity;
                s1.Description = NewProduct.Description;
                objProduct.SubmitChanges();
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
            var s1 = objProduct.ProductsTBs.SingleOrDefault(s => s.ProductId == id);
            objProduct.ProductsTBs.DeleteOnSubmit(s1);
            objProduct.SubmitChanges();
            return RedirectToAction("index");
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

        public ActionResult SearchProduct()
        {
            return View();
        }
    }
}
