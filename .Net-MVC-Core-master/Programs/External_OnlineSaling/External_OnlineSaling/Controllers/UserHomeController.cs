using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using External_OnlineSaling.Models;
using External_OnlineSaling.Models.DAL;
using Newtonsoft.Json;
using System.IO;


namespace External_OnlineSaling.Controllers
{
    public class UserHomeController : Controller
    {
        // GET: UserHome
        _IAllRepository<ProductTB> objinterface;
        _IAllRepository<UserTB> objuser;
        _IAllRepository<CountryTB> objcountry;
        _IAllRepository<StateTB> objstate;
        _IAllRepository<OrderTB> objorder;
        _IAllRepository<OrderDetailTB> objorderdetail;
        public UserHomeController()
        {
            this.objinterface =new AllRepository<ProductTB>();
            this.objuser = new AllRepository<UserTB>();
            this.objcountry = new AllRepository<CountryTB>();
            this.objstate = new AllRepository<StateTB>();
            this.objorder = new AllRepository<OrderTB>();
            this.objorderdetail = new AllRepository<OrderDetailTB>();
        }
        public ActionResult Index()
        {
            return View(objinterface.GetData());
        }

        // GET: UserHome/Details/5
        public ActionResult Details(int id)
        {
            
            return View(objinterface.GetDataById(c => c.ProductId == id));
        }

        // GET: UserHome/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserHome/Create
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

        // GET: UserHome/Edit/5
        public ActionResult Order(int id)
        {
            var product=objinterface.GetDataById(c => c.ProductId == id);
            OrderClass orderdata = new OrderClass();
            //orderdata.ProductId = product.ProductId;
            ViewBag.pid = product.ProductId;
            orderdata.UserId = Convert.ToInt32(Session["userid"]);
            ViewBag.Uid = orderdata.UserId;
            var user = objuser.GetDataById(c=>c.UserId==orderdata.UserId);
            orderdata.Date =Convert.ToDateTime( DateTime.Now.ToShortDateString());
            // ViewBag.UserList = new SelectList(user, "UserId", "Username", orderdata.UserId);
            ViewBag.User = user.Username;
            ViewBag.ProductName = product.ProductName;
            var country = objcountry.GetData();
            ViewBag.CountryList = new SelectList(country, "CountryId", "CountryName");

            return View(orderdata);
        }

        // POST: UserHome/Edit/5
        [HttpPost]
        public ActionResult Order(int id, FormCollection collection)
        {
            try
            {
                OrderClass order = new OrderClass();
                OrderTB otb = new OrderTB();
                otb.UserId = Convert.ToInt32(collection["UserId"]);
                otb.Date =Convert.ToDateTime(collection["Date"]);
                otb.TotalAmount = Convert.ToInt64(collection["TotalAmount"]);
                objorder.InsertData(otb);
                objorder.save();
                int latestid = otb.OrderId;

                OrderDetailTB odtb = new OrderDetailTB();
                odtb.OrderId = latestid;
                odtb.ProductId = Convert.ToInt32(collection["pid"]);
                odtb.Qty = Convert.ToInt32(collection["Qty"]);
                odtb.Address = collection["Address"].ToString();
                odtb.CountryId = Convert.ToInt32(collection["CountryId"]);
                odtb.StateId = Convert.ToInt32(collection["Sid"]);
                odtb.CityId = Convert.ToInt32(collection["Cid"]);

                objorderdetail.InsertData(odtb);
                objorderdetail.save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserHome/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserHome/Delete/5
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
        [HttpPost]
        public JsonResult GetTotal(int id,int qty)
        {
            var product = objinterface.GetDataById(c => c.ProductId == id);
            var total = qty * product.Price;
            return Json(new { Status = "Success",Total=total , JsonRequestBehavior.AllowGet });
        }
        [HttpGet]
        public JsonResult GetState(int cid)
        {
           
            DataContextDataContext cd = new DataContextDataContext();
            var data =from m in cd.StateTBs where m.CountryId==cid select new { StateId=m.StateId,StateName=m.StateName};
            return Json(new { Result=data }, JsonRequestBehavior.AllowGet);

        }
        [HttpGet]
        public JsonResult GetCity(int Sid)
        {
            DataContextDataContext cd = new DataContextDataContext();
            var data = from m in cd.CityTBs where m.StateId == Sid select new { CityId = m.CityId, CityName = m.CityName };
            return Json(new { Result = data }, JsonRequestBehavior.AllowGet);
        }
    }
}
