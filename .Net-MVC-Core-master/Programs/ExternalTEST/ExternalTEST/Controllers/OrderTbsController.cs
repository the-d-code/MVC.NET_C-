using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExternalTEST.Models;

namespace ExternalTEST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderTbsController : ControllerBase
    {
        private readonly ExternalContext _context;

        public OrderTbsController(ExternalContext context)
        {
            _context = context;
        }

        // GET: api/OrderTbs
        [HttpGet]
        public  IEnumerable<Class> GetOrderTb()
        {
            //var data = from m in _context.OrderTb join d in _context.ProductTb on m.ProductId equals d.ProductId join c in _context.CustomerTb on m.CustomerId equals c.CustomerId select new {  m.Date  , m.TotalAmount, c.CustomerName, d.ProductName, m.Qty };

            //var data = _context.OrderTb.ToList();
            //foreach(var i in data)
            //{
            //    i.Product = _context.ProductTb.Where(p => p.ProductId == i.ProductId).FirstOrDefault();
            //    i.Customer= _context.CustomerTb.Where(p => p.CustomerId == i.CustomerId).FirstOrDefault();
            //}

            var data = (_context.OrderTb.Include(s => s.Product).Include(s => s.Customer).Select(p => new Class()
            {
                OrderId = p.OrderId,
                Date = p.Date,
                Qty = p.Qty,
                ProductName = p.Product.ProductName,
                CustomerName = p.Customer.CustomerName,
                TotalAmount = p.TotalAmount

            })).ToList<Class>();

            return data;
        }





        // GET: api/OrderTbs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderTb>> GetOrderTb(int id)
        {
            var orderTb = await _context.OrderTb.FindAsync(id);

            if (orderTb == null)
            {
                return NotFound();
            }

            return orderTb;
        }

        // PUT: api/OrderTbs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderTb(int id, OrderTb orderTb)
        {
            if (id != orderTb.OrderId)
            {
                return BadRequest();
            }

            _context.Entry(orderTb).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderTbExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/OrderTbs
        [HttpPost]
        public async Task<ActionResult<OrderTb>> PostOrderTb(OrderTb orderTb)
        {
            _context.OrderTb.Add(orderTb);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrderTb", new { id = orderTb.OrderId }, orderTb);
        }

        // DELETE: api/OrderTbs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<OrderTb>> DeleteOrderTb(int id)
        {
            var orderTb = await _context.OrderTb.FindAsync(id);
            if (orderTb == null)
            {
                return NotFound();
            }

            _context.OrderTb.Remove(orderTb);
            await _context.SaveChangesAsync();

            return orderTb;
        }

        private bool OrderTbExists(int id)
        {
            return _context.OrderTb.Any(e => e.OrderId == id);
        }
    }
}
