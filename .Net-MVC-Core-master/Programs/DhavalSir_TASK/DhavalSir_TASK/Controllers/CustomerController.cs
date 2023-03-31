using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DhavalSir_TASK.Models;
namespace DhavalSir_TASK.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        ProductsDataContext objcust = new ProductsDataContext();
        public ActionResult Index()
        {
            var c1 = from c in objcust.CustomerTBs select c;
            return View(c1);
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            var c2 = from c in objcust.CustomerTBs where c.CustomerId == id select c;
            return View(c2.First());
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(CustomerTB cust)
        {
            try
            {
                objcust.CustomerTBs.InsertOnSubmit(cust);
                objcust.SubmitChanges();
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            var c2 = from c in objcust.CustomerTBs where c.CustomerId == id select c;
            return View(c2.First());
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id,CustomerTB cust)
        {
            try
            {
                var c2 = from c in objcust.CustomerTBs where c.CustomerId ==id select c;
                c2.First().CustomerName = cust.CustomerName;
                c2.First().Age = cust.Age;
                c2.First().Email = cust.Email;
                c2.First().Gender = cust.Gender;
                objcust.SubmitChanges();
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            var c3 = from c in objcust.CustomerTBs where c.CustomerId == id select c;
            objcust.CustomerTBs.DeleteOnSubmit(c3.First());
            objcust.SubmitChanges();
            return RedirectToAction("Index");
        }

        // POST: Customer/Delete/5
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
