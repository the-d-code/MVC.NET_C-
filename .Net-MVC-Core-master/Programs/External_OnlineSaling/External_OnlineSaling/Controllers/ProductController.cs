using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using External_OnlineSaling.Models.DAL;
using External_OnlineSaling.Models;
using System.Globalization;

namespace External_OnlineSaling.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private _IAllRepository<ProductTB> objinterface;
        _IAllRepository<OrderDetailTB> objorderdetail;
        _IAllRepository<CategoryTB> objcat;
        public ProductController()
        {
            this.objinterface = new AllRepository<ProductTB>();
            this.objorderdetail = new AllRepository<OrderDetailTB>();
            this.objcat = new AllRepository<CategoryTB>();
        }
        public ActionResult Index()
        {
            return View(from m in objinterface.GetData() select m);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {

            return View(objinterface.GetDataById(c=>c.ProductId==id));
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            var category = objcat.GetData();
            ViewBag.catlist = new SelectList(category, "CategoryId", "Category");
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(ProductTB pdata)
        {
            try
            {
                
                objinterface.InsertData(pdata);
                objinterface.save();

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
            var data = objinterface.GetDataById(s => s.ProductId == id);
            return View(data);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ProductTB product)
        {
            try
            {
                var data = objinterface.GetDataById(s => s.ProductId == id);
                data.ProductName = product.ProductName;
                data.MfgDate = product.MfgDate;
                data.Price = product.Price;
                data.CategoryId = product.CategoryId;
                objinterface.save();


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
            var data = objinterface.GetDataById(s => s.ProductId == id);
           

            return View(data);
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ProductTB data)
        {
            try
            {
                var dataa = objinterface.GetDataById(s => s.ProductId == id);
                // TODO: Add delete logic here
                objinterface.DeleteData(dataa);
                objinterface.save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Orders()
        {

            return View(objorderdetail.GetData());
        }
        public JsonResult GetProducts(string product)
        {

            DataContextDataContext dc = new DataContextDataContext();
            var data = from m in dc.ProductTBs where m.ProductName.Contains(product) select new { ProductId = m.ProductId, ProductName = m.ProductName, MfgDate = m.MfgDate.ToString(), Price = m.Price, CategoryName = m.CategoryTB.Category, Description = m.Description };
            //var data1 = dc.ProductTBs.Contains<object>(product);
            //var data = (from m in dc.ProductTBs select new { ProductId = m.ProductId, ProductName = m.ProductName, MfgDate = m.MfgDate.ToString(), Price = m.Price, CategoryName = m.CategoryTB.Category, Description = m.Description }).Contains(product);
            //var data = from x in data1 select new { };
            return Json(new { Result = data }, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetProductsDate(DateTime date1,DateTime date2)
        {
            var date11 = date1.ToLongDateString();
            var date22 = date2.ToLongDateString();

            var Date1=date1.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            var Date2=date2.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            DataContextDataContext dc = new DataContextDataContext();
            var data = from m in dc.ProductTBs where m.MfgDate >= Convert.ToDateTime(Date1) && m.MfgDate <= Convert.ToDateTime(Date2)
                       select new {
                ProductId = m.ProductId,
                ProductName = m.ProductName,
                MfgDate = m.MfgDate,
                Price = m.Price,
                CategoryName = m.CategoryTB.Category,
                Description = m.Description

            };
            return Json(new { Result = data }, JsonRequestBehavior.AllowGet);
        }
    }
}
