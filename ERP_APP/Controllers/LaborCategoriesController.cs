using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ERP_APP.Data;

namespace ERP_APP.Controllers
{
    public class LaborCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LaborCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LaborCategories
        public async Task<IActionResult> Index()
        {
              return _context.LaborCategories != null ? 
                          View(await _context.LaborCategories.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.LaborCategories'  is null.");
        }

        // GET: LaborCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.LaborCategories == null)
            {
                return NotFound();
            }

            var laborCategory = await _context.LaborCategories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (laborCategory == null)
            {
                return NotFound();
            }

            return View(laborCategory);
        }

        // GET: LaborCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LaborCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Id,DateCreated,DateModified")] LaborCategory laborCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(laborCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(laborCategory);
        }

        // GET: LaborCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.LaborCategories == null)
            {
                return NotFound();
            }

            var laborCategory = await _context.LaborCategories.FindAsync(id);
            if (laborCategory == null)
            {
                return NotFound();
            }
            return View(laborCategory);
        }

        // POST: LaborCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Id,DateCreated,DateModified")] LaborCategory laborCategory)
        {
            if (id != laborCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(laborCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LaborCategoryExists(laborCategory.Id))
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
            return View(laborCategory);
        }

        // GET: LaborCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.LaborCategories == null)
            {
                return NotFound();
            }

            var laborCategory = await _context.LaborCategories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (laborCategory == null)
            {
                return NotFound();
            }

            return View(laborCategory);
        }

        // POST: LaborCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.LaborCategories == null)
            {
                return Problem("Entity set 'ApplicationDbContext.LaborCategories'  is null.");
            }
            var laborCategory = await _context.LaborCategories.FindAsync(id);
            if (laborCategory != null)
            {
                _context.LaborCategories.Remove(laborCategory);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LaborCategoryExists(int id)
        {
          return (_context.LaborCategories?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
