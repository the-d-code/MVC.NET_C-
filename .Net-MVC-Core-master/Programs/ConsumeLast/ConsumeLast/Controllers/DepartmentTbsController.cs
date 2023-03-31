using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ConsumeLast.Models;

namespace ConsumeLast.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentTbsController : ControllerBase
    {
        private readonly EmployeeContext _context;

        public DepartmentTbsController(EmployeeContext context)
        {
            _context = context;
        }

        // GET: api/DepartmentTbs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DepartmentTb>>> GetDepartmentTb()
        {
            return await _context.DepartmentTb.ToListAsync();
        }

        // GET: api/DepartmentTbs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DepartmentTb>> GetDepartmentTb(int id)
        {
            var departmentTb = await _context.DepartmentTb.FindAsync(id);

            if (departmentTb == null)
            {
                return NotFound();
            }

            return departmentTb;
        }

        // PUT: api/DepartmentTbs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepartmentTb(int id, DepartmentTb departmentTb)
        {
            if (id != departmentTb.DepartmentId)
            {
                return BadRequest();
            }

            _context.Entry(departmentTb).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepartmentTbExists(id))
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

        // POST: api/DepartmentTbs
        [HttpPost]
        public async Task<ActionResult<DepartmentTb>> PostDepartmentTb(DepartmentTb departmentTb)
        {
            _context.DepartmentTb.Add(departmentTb);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDepartmentTb", new { id = departmentTb.DepartmentId }, departmentTb);
        }

        // DELETE: api/DepartmentTbs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DepartmentTb>> DeleteDepartmentTb(int id)
        {
            var departmentTb = await _context.DepartmentTb.FindAsync(id);
            if (departmentTb == null)
            {
                return NotFound();
            }

            _context.DepartmentTb.Remove(departmentTb);
            await _context.SaveChangesAsync();

            return departmentTb;
        }

        private bool DepartmentTbExists(int id)
        {
            return _context.DepartmentTb.Any(e => e.DepartmentId == id);
        }
    }
}
