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
    public class ProductTbsController : ControllerBase
    {
        private readonly ExternalContext _context;

        public ProductTbsController(ExternalContext context)
        {
            _context = context;
        }

        // GET: api/ProductTbs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductTb>>> GetProductTb()
        {
            return await _context.ProductTb.ToListAsync();
        }

        // GET: api/ProductTbs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductTb>> GetProductTb(int id)
        {
            var productTb = await _context.ProductTb.FindAsync(id);

            if (productTb == null)
            {
                return NotFound();
            }

            return productTb;
        }

        // PUT: api/ProductTbs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductTb(int id, ProductTb productTb)
        {
            if (id != productTb.ProductId)
            {
                return BadRequest();
            }

            _context.Entry(productTb).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductTbExists(id))
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

        // POST: api/ProductTbs
        [HttpPost]
        public async Task<ActionResult<ProductTb>> PostProductTb(ProductTb productTb)
        {
            _context.ProductTb.Add(productTb);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductTb", new { id = productTb.ProductId }, productTb);
        }

        // DELETE: api/ProductTbs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProductTb>> DeleteProductTb(int id)
        {
            var productTb = await _context.ProductTb.FindAsync(id);
            if (productTb == null)
            {
                return NotFound();
            }

            _context.ProductTb.Remove(productTb);
            await _context.SaveChangesAsync();

            return productTb;
        }

        private bool ProductTbExists(int id)
        {
            return _context.ProductTb.Any(e => e.ProductId == id);
        }
    }
}
