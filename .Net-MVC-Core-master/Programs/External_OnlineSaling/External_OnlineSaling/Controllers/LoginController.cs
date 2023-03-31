using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using External_OnlineSaling.Models;
using External_OnlineSaling.Models.DAL;

namespace External_OnlineSaling.Controllers
{
    public class LoginController : Controller
    {
        _IAllRepository<UserTB> objinterface;
       
        DataContextDataContext dc = new DataContextDataContext();
        public LoginController()
        {
            this.objinterface = new AllRepository<UserTB>();
         
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult index(string uname,string pass)
        {
           
            var data = dc.UserTBs.Where((s => s.Username == uname && s.Password==pass)).SingleOrDefault();
            if (data != null)
            {
                if (data.UserType.ToLower() == "admin")
                {
                    Session["adminid"] = data.UserId;
                    TempData["adminname"] = data.Username;
                    return RedirectToAction("index", "Product");
                }
                else
                {
                    Session["userid"] = data.UserId;
                    TempData["username"] = data.Username.ToString();
                   return RedirectToAction("index", "UserHome");
                }
            }
            else
            {
                ViewBag.err = "Invalid Username/Password";
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
