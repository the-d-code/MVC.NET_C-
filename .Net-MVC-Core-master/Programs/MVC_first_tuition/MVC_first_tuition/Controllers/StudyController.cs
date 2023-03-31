using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_first_tuition.Controllers
{
    public class StudyController : Controller
    {
        // GET: Study
        public ActionResult Index()
        {
            ViewBag.mscit = "Hello User";
            return View();
        }
        public ActionResult Show()
        {

            return View();
        }

        [HttpPost]
       public ActionResult Show(FormCollection data)
        {
            
            string s1 = Request["name"];
            string s2 = Request["gender"];

            if(s1=="Mscit" && s2=="Male")
            {
                ViewBag.name = s1;
                Session["names"] = s1;
                return View("Welcome");
            }
            else
                {

                        Response.Write("U Are Female So Not Allowed");
            }
          

            return View();
        }

    }
}