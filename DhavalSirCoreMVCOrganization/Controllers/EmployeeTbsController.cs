using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DhavalSirCoreMVCOrganization.Models;

namespace DhavalSirCoreMVCOrganization.Controllers
{
    public class EmployeeTbsController : Controller
    {
        private readonly EmployeeContext _context;

        public EmployeeTbsController(EmployeeContext context)
        {
            _context = context;
        }

        // GET: EmployeeTbs
        public async Task<IActionResult> Index()
        {
            return View(await _context.EmployeeTb.ToListAsync());
        }

        // GET: EmployeeTbs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeTb = await _context.EmployeeTb
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employeeTb == null)
            {
                return NotFound();
            }

            return View(employeeTb);
        }

        // GET: EmployeeTbs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmployeeTbs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeId,Name,DepartmentId,Salary,Gender")] EmployeeTb employeeTb)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employeeTb);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employeeTb);
        }

        // GET: EmployeeTbs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeTb = await _context.EmployeeTb.FindAsync(id);
            if (employeeTb == null)
            {
                return NotFound();
            }
            return View(employeeTb);
        }

        // POST: EmployeeTbs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeId,Name,DepartmentId,Salary,Gender")] EmployeeTb employeeTb)
        {
            if (id != employeeTb.EmployeeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeeTb);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeTbExists(employeeTb.EmployeeId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(employeeTb);
        }

        // GET: EmployeeTbs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeTb = await _context.EmployeeTb
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employeeTb == null)
            {
                return NotFound();
            }

            return View(employeeTb);
        }

        // POST: EmployeeTbs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeeTb = await _context.EmployeeTb.FindAsync(id);
            _context.EmployeeTb.Remove(employeeTb);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeTbExists(int id)
        {
            return _context.EmployeeTb.Any(e => e.EmployeeId == id);
        }
    }
}
