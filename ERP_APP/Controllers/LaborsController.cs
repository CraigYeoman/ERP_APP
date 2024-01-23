using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ERP_APP.Data;
using AutoMapper;
using ERP_APP.Models;

namespace ERP_APP.Controllers
{
    public class LaborsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public LaborsController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        // GET: Labors
        public async Task<IActionResult> Index()
        {
            var labors = await _context.Labors.ToListAsync();
            return View(labors);
        }

        // GET: Labors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Labors == null)
            {
                return NotFound();
            }

            var labor = await _context.Labors
                .Include(l => l.LaborCategory)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (labor == null)
            {
                return NotFound();
            }

            return View(labor);
        }

        // GET: Labors/Create
        public IActionResult Create()
        {
            ViewData["LaborCategoryId"] = new SelectList(_context.LaborCategories, "Id", "Discriminator");
            return View();
        }

        // POST: Labors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LaborCreateVM laborCreateVM)
        {
            if (ModelState.IsValid)
            {
                _context.Add(laborCreateVM);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LaborCategoryId"] = new SelectList(_context.LaborCategories, "Id", "Discriminator", laborCreateVM.LaborCategoryId);
            return View(laborCreateVM);
        }

        // GET: Labors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Labors == null)
            {
                return NotFound();
            }

            var labor = await _context.Labors.FindAsync(id);
            if (labor == null)
            {
                return NotFound();
            }
            ViewData["LaborCategoryId"] = new SelectList(_context.LaborCategories, "Id", "Discriminator", labor.LaborCategoryId);
            return View(labor);
        }

        // POST: Labors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Price,LaborCategoryId,Id,DateCreated,DateModified")] Labor labor)
        {
            if (id != labor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(labor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LaborExists(labor.Id))
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
            ViewData["LaborCategoryId"] = new SelectList(_context.LaborCategories, "Id", "Discriminator", labor.LaborCategoryId);
            return View(labor);
        }

        // GET: Labors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Labors == null)
            {
                return NotFound();
            }

            var labor = await _context.Labors
                .Include(l => l.LaborCategory)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (labor == null)
            {
                return NotFound();
            }

            return View(labor);
        }

        // POST: Labors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Labors == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Labors'  is null.");
            }
            var labor = await _context.Labors.FindAsync(id);
            if (labor != null)
            {
                _context.Labors.Remove(labor);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LaborExists(int id)
        {
          return (_context.Labors?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
