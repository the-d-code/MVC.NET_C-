using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DhavalSir_TASK.Models;
namespace DhavalSir_TASK.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Orders
        ProductsDataContext objorder = new ProductsDataContext();
        public ActionResult Index()
        {

            return View(objorder.OrderDetailTBs.ToList());
        }

        // GET: Orders/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            var customerdata = objorder.CustomerTBs.ToList();
            ViewBag.CustomerList = new SelectList(customerdata, "CustomerId", "CustomerName");
            var productdata = objorder.ProductsTBs.ToList();
            ViewBag.ProductList = new SelectList(productdata, "ProductId", "ProductName");
            return View();
        }

        // POST: Orders/Create
        [HttpPost]
        public ActionResult Create(orderentry NewOrder)
        {
            try
            {
                //var order = new OrderTB
                //{
                //    CustomerId = NewOrder.CustomerId,
                //    Date = Convert.ToDateTime(NewOrder.Date),
                //    TotalAmount=NewOrder.TotalAmount

                //};
                //var orderdetail = new OrderDetailTB();
                //using (var context = new ProductsDataContext())
                //{
                //    context.OrderTBs.InsertOnSubmit(order);
                //    orderdetail.OrderId = order.OrderId;
                //    context.OrderDetailTBs.InsertOnSubmit(orderdetail);
                //    //etc add your other classes
                //    context.SubmitChanges();

                //}
                // TODO: Add insert logic here


                OrderTB order = new OrderTB();

                

                order.CustomerId = NewOrder.CustomerId;
                order.Date = Convert.ToDateTime(NewOrder.Date);
                order.TotalAmount = NewOrder.TotalAmount;

                

                objorder.OrderTBs.InsertOnSubmit(order);

                objorder.SubmitChanges();
                int latestid = order.OrderId;
                
                OrderDetailTB odetail = new OrderDetailTB();

                odetail.ProductId = NewOrder.ProductId;
                odetail.OrderId = latestid;
                odetail.Rate = NewOrder.Rate;
                odetail.Qty = NewOrder.Qty;

                objorder.OrderDetailTBs.InsertOnSubmit(odetail);
                objorder.SubmitChanges();

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View(ex.ToString());
            }
        }

        // GET: Orders/Edit/5
        public ActionResult Edit(int id)
        {
            //var q = (from o in objorder.OrderTBs
            //         join od in objorder.OrderDetailTBs on o.OrderId equals od.OrderId
            //         join c in objorder.CustomerTBs on o.CustomerId equals c.CustomerId
            //         join p in objorder.ProductsTBs on od.ProductId equals p.ProductId
            //         where od.OrderDetailId == id
            //         select new { od.OrderDetailId, o.OrderId, c.CustomerId, p.ProductId, o.Date, o.TotalAmount, od.Qty, od.Rate }).ToList();

            orderentry neworder = new orderentry();

            var editdata = objorder.OrderDetailTBs.SingleOrDefault(d => d.OrderDetailId == id);
            var orderdata = objorder.OrderTBs.SingleOrDefault(s => s.OrderId == editdata.OrderId);
            var pdata = objorder.ProductsTBs.SingleOrDefault(p => p.ProductId == editdata.ProductId);
            var cdata = objorder.CustomerTBs.SingleOrDefault(c => c.CustomerId == orderdata.CustomerId);
            var customerdata = objorder.CustomerTBs.ToList();
            ViewBag.CustomerList = new SelectList(customerdata, "CustomerId", "CustomerName",orderdata.CustomerId);
            var productdata = objorder.ProductsTBs.ToList();
            ViewBag.ProductList = new SelectList(productdata, "ProductId", "ProductName",editdata.ProductId);

            //orderentry odd = new orderentry();
            neworder.OrderdetailId = editdata.OrderDetailId;
            neworder.OrderId = orderdata.OrderId;
            neworder.ProductId = pdata.ProductId;
            neworder.CustomerId = cdata.CustomerId;
            neworder.Date = orderdata.Date.ToString();
            neworder.Qty =Convert.ToInt32( editdata.Qty);
            neworder.Rate =Convert.ToInt32( editdata.Rate);
            neworder.TotalAmount =Convert.ToInt32(orderdata.TotalAmount);




            return View(neworder);
        }

        // POST: Orders/Edit/5
        [HttpPost]
        public ActionResult Edit(int id,orderentry NewOrder)
        {
            try
            {
               // orderentry neworder = new orderentry();
                var editdata = objorder.OrderDetailTBs.SingleOrDefault(d => d.OrderDetailId == id);
                var orderdata = objorder.OrderTBs.SingleOrDefault(s => s.OrderId == editdata.OrderId);
                var pdata = objorder.ProductsTBs.SingleOrDefault(p => p.ProductId == editdata.ProductId);
                var cdata = objorder.CustomerTBs.SingleOrDefault(c => c.CustomerId == orderdata.CustomerId);
                var customerdata = objorder.CustomerTBs.ToList();
                ViewBag.CustomerList = new SelectList(customerdata, "CustomerId", "CustomerName", orderdata.CustomerId);
                var productdata = objorder.ProductsTBs.ToList();
                ViewBag.ProductList = new SelectList(productdata, "ProductId", "ProductName", editdata.ProductId);

                //orderentry odd = new orderentry();

                //editdata.OrderDetailId = NewOrder.OrderdetailId;
                //orderdata.OrderId = NewOrder.OrderId;
               
                orderdata.Date = Convert.ToDateTime(NewOrder.Date);
                editdata.Qty = NewOrder.Qty;
                editdata.Rate = NewOrder.Rate;
                orderdata.TotalAmount =NewOrder.TotalAmount;

                UpdateModel(NewOrder);

            
                objorder.SubmitChanges();

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View(ex.ToString());
            }
        }

        // GET: Orders/Delete/5
        public ActionResult Delete(int id)
        {
            var deletedata = objorder.OrderDetailTBs.SingleOrDefault(d=>d.OrderDetailId==id);
            var orderdata = objorder.OrderTBs.SingleOrDefault(s=>s.OrderId==deletedata.OrderId);
            objorder.OrderDetailTBs.DeleteOnSubmit(deletedata);
            objorder.OrderTBs.DeleteOnSubmit(orderdata);
            objorder.SubmitChanges();
            return RedirectToAction("Index");
        }

        // POST: Orders/Delete/5
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

        
        public ActionResult Search()
        {
            return View();
           
        }
        [HttpPost]
        public ActionResult Search(OrderTB odetail)
        {
            string d1 = Request["date1"].ToString();
            string d2 = Request["date2"].ToString();

            if (d1.Equals(d2))
            {
                Response.Write("Same Date");
            }
            var q1 = from x in objorder.OrderTBs where x.Date >= Convert.ToDateTime(d1) && x.Date <= Convert.ToDateTime(d2) select x;

            return View(q1.ToList());

        }

        public ActionResult DetailsOfOrder(int id)
        {
            return View(objorder.OrderDetailTBs.SingleOrDefault(s=>s.OrderId==id));
        }





    }
}
