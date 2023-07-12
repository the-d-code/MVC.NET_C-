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
    public class DepartmentTbsController : Controller
    {
        private readonly EmployeeContext _context;

        public DepartmentTbsController(EmployeeContext context)
        {
            _context = context;
        }

        // GET: DepartmentTbs
        public async Task<IActionResult> Index()
        {
            return View(await _context.DepartmentTb.ToListAsync());
        }

        // GET: DepartmentTbs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departmentTb = await _context.DepartmentTb
                .FirstOrDefaultAsync(m => m.DepartmentId == id);
            if (departmentTb == null)
            {
                return NotFound();
            }

            return View(departmentTb);
        }

        // GET: DepartmentTbs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DepartmentTbs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DepartmentId,Department")] DepartmentTb departmentTb)
        {
            if (ModelState.IsValid)
            {
                _context.Add(departmentTb);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(departmentTb);
        }

        // GET: DepartmentTbs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departmentTb = await _context.DepartmentTb.FindAsync(id);
            if (departmentTb == null)
            {
                return NotFound();
            }
            return View(departmentTb);
        }

        // POST: DepartmentTbs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DepartmentId,Department")] DepartmentTb departmentTb)
        {
            if (id != departmentTb.DepartmentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(departmentTb);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DepartmentTbExists(departmentTb.DepartmentId))
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
            return View(departmentTb);
        }

        // GET: DepartmentTbs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departmentTb = await _context.DepartmentTb
                .FirstOrDefaultAsync(m => m.DepartmentId == id);
            if (departmentTb == null)
            {
                return NotFound();
            }

            return View(departmentTb);
        }

        // POST: DepartmentTbs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var departmentTb = await _context.DepartmentTb.FindAsync(id);
            _context.DepartmentTb.Remove(departmentTb);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DepartmentTbExists(int id)
        {
            return _context.DepartmentTb.Any(e => e.DepartmentId == id);
        }
    }
}
