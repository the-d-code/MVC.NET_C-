using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MYAPI.Models;

namespace MYAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmptbsController : ControllerBase
    {
        private readonly StudyDBContext _context;

        public EmptbsController(StudyDBContext context)
        {
            _context = context;
        }

        // GET: api/Emptbs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Emptb>>> GetEmptb()
        {
            return await _context.Emptb.ToListAsync();
        }

        // GET: api/Emptbs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Emptb>> GetEmptb(int id)
        {
            var emptb = await _context.Emptb.FindAsync(id);

            if (emptb == null)
            {
                return NotFound();
            }

            return emptb;
        }

        // PUT: api/Emptbs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmptb(int id, Emptb emptb)
        {
            if (id != emptb.Id)
            {
                return BadRequest();
            }

            _context.Entry(emptb).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmptbExists(id))
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

        // POST: api/Emptbs
        [HttpPost]
        public async Task<ActionResult<Emptb>> PostEmptb(Emptb emptb)
        {
            _context.Emptb.Add(emptb);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmptb", new { id = emptb.Id }, emptb);
        }

        // DELETE: api/Emptbs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Emptb>> DeleteEmptb(int id)
        {
            var emptb = await _context.Emptb.FindAsync(id);
            if (emptb == null)
            {
                return NotFound();
            }

            _context.Emptb.Remove(emptb);
            await _context.SaveChangesAsync();

            return emptb;
        }

        private bool EmptbExists(int id)
        {
            return _context.Emptb.Any(e => e.Id == id);
        }
    }
}
