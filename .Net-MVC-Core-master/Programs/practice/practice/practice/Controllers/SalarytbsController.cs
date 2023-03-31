using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practice.Models;

namespace practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalarytbsController : ControllerBase
    {
        private readonly examdbContext _context;

        public SalarytbsController(examdbContext context)
        {
            _context = context;
        }

        // GET: api/Salarytbs
        //[HttpGet]
        //public async Task<IEnumerable<Salarytb>> GetSalarytbAsync()
        //{
        //    var x = _context.Salarytb;

        //  /* foreach( var y in x)
        //    {
        //        y.E = _context.Empptb.Where (i=>i.Eid ==y.Eid ).First ();
        //    }*/
        //    return (_context.Salarytb.Include (i=>i.E ).ToList() );
        //}


        [HttpGet]
        public IEnumerable<Salary_Empptb> GetSalarytbWithEmployee(bool includeEmp = false)
        {
            var x = _context.Salarytb;

            /* foreach( var y in x)
              {
                  y.E = _context.Empptb.Where (i=>i.Eid ==y.Eid ).First ();
              }*/
            var data = (_context.Salarytb.Include(i => i.E).Select(s => new Salary_Empptb()
            {
                Eid = s.Eid,
                Sid = s.Sid,
                Salary = s.Salary,
                Empname = s.E.Ename

            })).ToList<Salary_Empptb >();
            return data;
        }



        // GET: api/Salarytbs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSalarytb([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var salarytb = await _context.Salarytb.FindAsync(id);

            if (salarytb == null)
            {
                return NotFound();
            }

            return Ok(salarytb);
        }

        // PUT: api/Salarytbs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalarytb([FromRoute] int id, [FromBody] Salarytb salarytb)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != salarytb.Sid)
            {
                return BadRequest();
            }

            _context.Entry(salarytb).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalarytbExists(id))
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

        // POST: api/Salarytbs
        [HttpPost]
        public async Task<IActionResult> PostSalarytb([FromBody] Salarytb salarytb)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Salarytb.Add(salarytb);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSalarytb", new { id = salarytb.Sid }, salarytb);
        }

        // DELETE: api/Salarytbs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSalarytb([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var salarytb = await _context.Salarytb.FindAsync(id);
            if (salarytb == null)
            {
                return NotFound();
            }

            _context.Salarytb.Remove(salarytb);
            await _context.SaveChangesAsync();

            return Ok(salarytb);
        }

        private bool SalarytbExists(int id)
        {
            return _context.Salarytb.Any(e => e.Sid == id);
        }
    }
}