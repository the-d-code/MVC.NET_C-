using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExternalTuition.Models;

namespace ExternalTuition.Controllers
{
    public class ProductController : Controller
    {
        InternalDataContext objdc = new InternalDataContext();
        // GET: Product
        public ActionResult Index()
        {
            return View(objdc.ProductTBs.ToList());
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
        public ActionResult Create(HttpPostedFileBase ProductImage, ProductTB NewProduct)
        {
            try
            {
               

                string _FileName = "";
                if (ProductImage.ContentLength > 0)
                {
                    _FileName = Path.GetFileName(ProductImage.FileName);
                    string path = Path.Combine(Server.MapPath("~/UploadedFiles"), _FileName);
                    ProductImage.SaveAs(path);

                }
                NewProduct.Image = _FileName;
                objdc.ProductTBs.InsertOnSubmit(NewProduct);
                objdc.SubmitChanges();
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
            
            return View(objdc.ProductTBs.SingleOrDefault(x => x.ProductId == id));
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(HttpPostedFileBase ProductImage,int id,ProductTB editProduct)
        {
            try
            {
                // TODO: Add update logic here
                ProductTB updateProduct= objdc.ProductTBs.SingleOrDefault(x => x.ProductId == id);
                string _FileName = "";

                if (ProductImage !=null && ProductImage.ContentLength > 0)
                {

                    _FileName = Path.GetFileName(ProductImage.FileName);
                    string path = Path.Combine(Server.MapPath("~/UploadedFiles"), _FileName);
                    ProductImage.SaveAs(path);
                    updateProduct.Image = _FileName;

                }
                //updateProduct = editProduct;
                
                UpdateModel(updateProduct);
                objdc.SubmitChanges();
                
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
    }
}
