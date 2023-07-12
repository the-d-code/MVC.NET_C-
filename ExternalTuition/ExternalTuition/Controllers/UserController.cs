using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using ExternalTuition.Models;

namespace ExternalTuition.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        InternalDataContext dc = new InternalDataContext();
        public ActionResult Index()
        {

            return View(dc.ProductTBs.ToList());
        }
        [HttpPost]
        public ActionResult AddCart(CartTB c,FormCollection fc)
        {
           
            
            
           int proid=Convert.ToInt32 (fc["pid"]);
            c.ProductId = proid;
            c.UserId = int.Parse(Session["userid"].ToString());
            c.Qty =Convert.ToInt32(fc["txtqty"]);
            c.Price = Convert.ToInt32(fc["Price"]);
            dc.CartTBs.InsertOnSubmit(c);
            dc.SubmitChanges();
            Response.Write("<script>alert(Successfully Product Add To Cart)</script>");
            return RedirectToAction("index", "User");

        }
        public ActionResult DeleteCartItem(int id)
        {
           dc.CartTBs.DeleteOnSubmit( dc.CartTBs.Where(c => c.CartId == id).SingleOrDefault());
            dc.SubmitChanges();

            return RedirectToAction("DisplayCart","User");
        }
        public ActionResult DisplayCart()
        {
            var uid = int.Parse(Session["userid"].ToString());
            return View(dc.CartTBs.Where(p=>p.UserId==uid));
        }

        public ActionResult GoBuy()
        {
            var uid = int.Parse(Session["userid"].ToString());
            var cdata =/* from x in dc.CartTBs where x.UserId == uid select x;*/ dc.CartTBs.Where(o => o.UserId == uid).ToList();
            
            var name="";
            decimal sum = 0;
            foreach(var d in cdata)
            {
                name = d.UserTB.Username;
               
                sum = sum + Convert.ToDecimal(d.Price * d.Qty);
            }
            ViewBag.total = sum;
            ViewBag.uname = name;
            
            return View();
        }

        [HttpPost]
        public ActionResult GoBuy(FormCollection collection)
        {
            UserTB user = new UserTB();
            user.Address = collection["Address"];
            user.ContactNo = collection["ContactNo"];
            dc.UserTBs.InsertOnSubmit(user);
            dc.SubmitChanges();
            var uid = int.Parse(Session["userid"].ToString());
            var cdata =/* from x in dc.CartTBs where x.UserId == uid select x;*/ dc.CartTBs.Where(o => o.UserId == uid).ToList();
            OrderTB otb = new OrderTB();
            otb.UserId = uid;
            otb.OrderDate = DateTime.Now;
            otb.GrandTotal =Convert.ToDecimal(collection["Total"]);

            dc.OrderTBs.InsertOnSubmit(otb);
            dc.SubmitChanges();
            int oid = otb.OrderId;
            
            foreach(var d in cdata)
            {
                OrderDetailTB odetail = new OrderDetailTB();
                odetail.OrderId = oid;
                odetail.ProductId = d.ProductId;
                odetail.Qty = d.Qty;
                odetail.Price = d.Price;

                dc.OrderDetailTBs.InsertOnSubmit(odetail);
                dc.SubmitChanges();
               
            }
            foreach(var s in cdata)
            {
                dc.CartTBs.DeleteOnSubmit((from m in dc.CartTBs where m.UserId == uid select m).FirstOrDefault());

                dc.SubmitChanges();
            }

            
           

            return RedirectToAction("Index");


        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
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

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
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

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
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
