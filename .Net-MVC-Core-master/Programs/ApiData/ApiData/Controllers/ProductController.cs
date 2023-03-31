using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiData.Models;
namespace ApiData.Controllers
{
    public class ProductController : ApiController
    {
        // GET: api/Product
        TempDataContext dc = new TempDataContext();
        public IEnumerable<Object> Get()
        {
            //var data =from m in dc.ProductTBs select new { m.ProductId ,m.ProductName,m.MfgDate,m.CategoryTB.Categiry,m.Price,m.IsAvailable};
            return (dc.ProductTBs.ToList());
        }

        // GET: api/Product/5
        public IEnumerable<Object> Get(int id)
        {
            var data = from m in dc.ProductTBs
                       where m.ProductId == id
                       select new
                       {
                           m.ProductId,
                           m.ProductName,
                           m.MfgDate,
                           m.CategoryId,
                           m.Price,
                           m.IsAvailable
                       };
            return data.ToList();
        }

        // POST: api/Product
        public void Post([FromBody]ProductTB product)
        {
            dc.ProductTBs.InsertOnSubmit(product);
            dc.SubmitChanges();
        }

        // PUT: api/Product/5
        public void Put([FromBody]ProductTB product)
        {
            var olddata = dc.ProductTBs.Where(s => s.ProductId == product.ProductId).FirstOrDefault();
            olddata.ProductName = product.ProductName;
            olddata.CategoryId = product.CategoryId;
            olddata.MfgDate = product.MfgDate;
            olddata.Price = product.Price;
            olddata.IsAvailable = product.IsAvailable;

            dc.SubmitChanges();


        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
            ProductTB p = dc.ProductTBs.FirstOrDefault(s => s.ProductId == id);
            dc.ProductTBs.DeleteOnSubmit(p);
            dc.SubmitChanges();
        }
    }
}
