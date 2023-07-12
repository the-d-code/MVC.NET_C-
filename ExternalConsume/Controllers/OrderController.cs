using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExternalTEST.Models;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ExternalConsume.Controllers
{
    public class OrderController : Controller
    {

        // GET: Order
        public ActionResult Index()
        {
            IEnumerable<Class> Order = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:52269/api/");
                var responsetask = client.GetAsync("OrderTBs");
                responsetask.Wait();

                var result = responsetask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readtask = result.Content.ReadAsAsync<IList<Class>>();
                    Order = readtask.Result;
                }

            }

                return View(Order);
        }

        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Order/Create
        public ActionResult Create()
        {

            IEnumerable<CustomerTb> cust = null;
            IEnumerable<ProductTb> pro = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:52269/api/");
                var responsetask = client.GetAsync("CustomerTbs");
                responsetask.Wait();

                var result = responsetask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readtask = result.Content.ReadAsAsync<IList<CustomerTb>>();
                    cust = readtask.Result;
                    ViewBag.Cdata =new  SelectList(cust,"CustomerId","CustomerName");
                }

            }
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:52269/api/");
                var responsetask = client.GetAsync("ProductTbs");
                responsetask.Wait();

                var result = responsetask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readtask = result.Content.ReadAsAsync<IList<ProductTb>>();
                    pro = readtask.Result;
                    ViewBag.Pdata = new SelectList(pro, "ProductId", "ProductName");
                }

            }
            return View();
        }

        // POST: Order/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrderTb order)
        {
            try
            {
                using (var client=new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:52269/api/");
                    var posttask = client.PostAsJsonAsync<OrderTb>("OrderTbs", order);
                    posttask.Wait();
                    var Result = posttask.Result;
                    if (Result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            IEnumerable<CustomerTb> cust = null;
            IEnumerable<ProductTb> pro = null;
          

            OrderTb order = null;
            using(var client=new HttpClient())
            {
                client.BaseAddress= new Uri("http://localhost:52269/api/");
                var responsetask = client.GetAsync("OrderTbs/" + id.ToString());
                responsetask.Wait();
                var result = responsetask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readtask = result.Content.ReadAsAsync<OrderTb>();
                    readtask.Wait();
                    order = readtask.Result;
                    ViewBag.OrderId = order.OrderId;
                }

            }
            //using (var client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("http://localhost:52269/api/");
            //    var responsetask = client.GetAsync("OrderTbs/" + id.ToString());
            //    responsetask.Wait();

            //    var result = responsetask.Result;
            //    if (result.IsSuccessStatusCode)
            //    {
            //        var readtask = result.Content.ReadAsAsync<OrderTb>();
            //        order = readtask.Result;
            //    }

            //}

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:52269/api/");
                var responsetask = client.GetAsync("CustomerTbs");
                responsetask.Wait();

                var result = responsetask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readtask = result.Content.ReadAsAsync<IList<CustomerTb>>();
                    cust = readtask.Result;
                    ViewBag.Cdata = new SelectList(cust, "CustomerId", "CustomerName",order.CustomerId);
                }

            }
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:52269/api/");
                var responsetask = client.GetAsync("ProductTbs");
                responsetask.Wait();

                var result = responsetask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readtask = result.Content.ReadAsAsync<IList<ProductTb>>();
                    pro = readtask.Result;
                    ViewBag.Pdata = new SelectList(pro, "ProductId", "ProductName",order.ProductId);
                }

            }

            return View(order);
        }



        // POST: Order/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, OrderTb order)
        {
            try
            {
                using (var client=new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:52269/api/");
                    var puttask = client.PutAsJsonAsync<OrderTb>("OrderTbs/" + order.OrderId, order);
                    puttask.Wait();
                    var result = puttask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }
                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            using (var client =new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:52269/api/");
                var deletetask = client.DeleteAsync("OrderTbs/" + id.ToString());
                deletetask.Wait();
                var result = deletetask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }

            }
            return RedirectToAction("Index");
        }

        // POST: Order/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}