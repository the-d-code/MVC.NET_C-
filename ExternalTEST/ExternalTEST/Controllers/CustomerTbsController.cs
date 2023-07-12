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
    public class CustomerTbsController : ControllerBase
    {
        private readonly ExternalContext _context;

        public CustomerTbsController(ExternalContext context)
        {
            _context = context;
        }

        // GET: api/CustomerTbs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerTb>>> GetCustomerTb()
        {
            return await _context.CustomerTb.ToListAsync();
        }

        // GET: api/CustomerTbs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerTb>> GetCustomerTb(int id)
        {
            var customerTb = await _context.CustomerTb.FindAsync(id);

            if (customerTb == null)
            {
                return NotFound();
            }

            return customerTb;
        }

        // PUT: api/CustomerTbs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomerTb(int id, CustomerTb customerTb)
        {
            if (id != customerTb.CustomerId)
            {
                return BadRequest();
            }

            _context.Entry(customerTb).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerTbExists(id))
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

        // POST: api/CustomerTbs
        [HttpPost]
        public async Task<ActionResult<CustomerTb>> PostCustomerTb(CustomerTb customerTb)
        {
            _context.CustomerTb.Add(customerTb);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomerTb", new { id = customerTb.CustomerId }, customerTb);
        }

        // DELETE: api/CustomerTbs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CustomerTb>> DeleteCustomerTb(int id)
        {
            var customerTb = await _context.CustomerTb.FindAsync(id);
            if (customerTb == null)
            {
                return NotFound();
            }

            _context.CustomerTb.Remove(customerTb);
            await _context.SaveChangesAsync();

            return customerTb;
        }

        private bool CustomerTbExists(int id)
        {
            return _context.CustomerTb.Any(e => e.CustomerId == id);
        }
    }
}
