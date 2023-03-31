using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FirstWebapi.Models;

namespace FirstWebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpTbsController : ControllerBase
    {
        private readonly ApiStudyDBContext _context;

        public EmpTbsController(ApiStudyDBContext context)
        {
            _context = context;
        }

        // GET: api/EmpTbs
        [HttpGet]
        public IEnumerable<EmpTb> GetEmpTb()
        {
            return _context.EmpTb;
        }

        // GET: api/EmpTbs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmpTb([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var empTb = await _context.EmpTb.FindAsync(id);

            if (empTb == null)
            {
                return NotFound();
            }

            return Ok(empTb);
        }

        // PUT: api/EmpTbs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmpTb([FromRoute] int id, [FromBody] EmpTb empTb)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != empTb.EmployeeId)
            {
                return BadRequest();
            }

            _context.Entry(empTb).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpTbExists(id))
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

        // POST: api/EmpTbs
        [HttpPost]
        public async Task<IActionResult> PostEmpTb([FromBody] EmpTb empTb)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.EmpTb.Add(empTb);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmpTb", new { id = empTb.EmployeeId }, empTb);
        }

        // DELETE: api/EmpTbs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmpTb([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var empTb = await _context.EmpTb.FindAsync(id);
            if (empTb == null)
            {
                return NotFound();
            }

            _context.EmpTb.Remove(empTb);
            await _context.SaveChangesAsync();

            return Ok(empTb);
        }

        private bool EmpTbExists(int id)
        {
            return _context.EmpTb.Any(e => e.EmployeeId == id);
        }
    }
}