using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExternalTuition.Models;

namespace ExternalTuition.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        InternalDataContext dc = new InternalDataContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string uname,string pass)
        {
           var data= dc.UserTBs.Where(s => s.Username == uname && s.Password == pass).SingleOrDefault();
            if (data!=null)
            {
                if (data.UserType.ToLower() == "admin")
                {
                    Session["adminid"] = data.UserId;
                    TempData["adminname"] = data.Username;
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    Session["userid"] = data.UserId;
                    TempData["username"] = data.Username;
                    return RedirectToAction("Index", "User");
                }
               
            }
            else
            {
                ViewBag.err = "Record Not Found.. Or Invalid Username Or Password";
                return View();
            }
        }
            
        // GET: Login/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
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

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
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

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
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
