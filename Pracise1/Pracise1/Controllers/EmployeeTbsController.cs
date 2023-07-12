using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pracise1.Models;
//using  System.Data.Entity
namespace Pracise1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeTbsController : ControllerBase
    {
        private readonly EmployeeContext _context;

        public EmployeeTbsController(EmployeeContext context)
        {
            _context = context;
        }

        // GET: api/EmployeeTbs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeTb>>> GetEmployeeTb()
        {
            //    var data = from m in _context.EmployeeTb select new { m.EmployeeId, m.Department.Department, m.Gender, m.Name, m.Salary };

           // List<EmployeeTb>  lst =await( _context.EmployeeTb.ToListAsync<EmployeeTb>());

            //var lst = await _context.EmployeeTb.Include(i => i.DepartmentId).ToListAsync;
                        //.FirstOrDefaultAsync(i => i.DepartmentId  == id);
            // IEnumerable<EmployeeTb> t;

            /*  foreach (var data in lst)
              {
                  var dpt = _context.DepartmentTb.Where(p => p.DepartmentId == data.DepartmentId).FirstOrDefault() ;
                  data.Department.Department = dpt.Department ;
              }*/

            return   await _context.EmployeeTb.ToListAsync();
        }

        // GET: api/EmployeeTbs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeTb>> GetEmployeeTb(int id)
        {
            var employeeTb = await _context.EmployeeTb.FindAsync(id);

            if (employeeTb == null)
            {
                return NotFound();
            }

            return employeeTb;
        }

        // PUT: api/EmployeeTbs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployeeTb(int id, EmployeeTb employeeTb)
        {
            if (id != employeeTb.EmployeeId)
            {
                return BadRequest();
            }

            _context.Entry(employeeTb).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeTbExists(id))
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

        // POST: api/EmployeeTbs
        [HttpPost]
        public async Task<ActionResult<EmployeeTb>> PostEmployeeTb(EmployeeTb employeeTb)
        {
            _context.EmployeeTb.Add(employeeTb);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployeeTb", new { id = employeeTb.EmployeeId }, employeeTb);
        }

        // DELETE: api/EmployeeTbs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EmployeeTb>> DeleteEmployeeTb(int id)
        {
            var employeeTb = await _context.EmployeeTb.FindAsync(id);
            if (employeeTb == null)
            {
                return NotFound();
            }

            _context.EmployeeTb.Remove(employeeTb);
            await _context.SaveChangesAsync();

            return employeeTb;
        }

        private bool EmployeeTbExists(int id)
        {
            return _context.EmployeeTb.Any(e => e.EmployeeId == id);
        }
    }
}
