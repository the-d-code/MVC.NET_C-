using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Service_MVC.localhost;
using Web_Service_MVC.Models;
namespace Web_Service_MVC.Controllers
{
    public class LoginController : Controller
    {
        WebService1 wc = new WebService1();

        // GET: Login
        public ActionResult Index()
        {
         
            return View();
        }
        [HttpPost]
        public ActionResult Index(UserTB user)
        {
          
            int data= wc.Login(user.Username, user.Password);
            if(data==1)
            {
                return RedirectToAction("Index","Employee");
            }
            else
            {
                ViewBag.err1 = "Wrong Username & Password";
                return View();
            }
           
        }
    }
}