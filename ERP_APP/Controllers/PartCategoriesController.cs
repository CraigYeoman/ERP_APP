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
    public class PartCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PartCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PartCategories
        public async Task<IActionResult> Index()
        {
              return _context.PartCategories != null ? 
                          View(await _context.PartCategories.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.PartCategories'  is null.");
        }

        // GET: PartCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PartCategories == null)
            {
                return NotFound();
            }

            var partCategory = await _context.PartCategories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (partCategory == null)
            {
                return NotFound();
            }

            return View(partCategory);
        }

        // GET: PartCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PartCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Id,DateCreated,DateModified")] PartCategory partCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(partCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(partCategory);
        }

        // GET: PartCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PartCategories == null)
            {
                return NotFound();
            }

            var partCategory = await _context.PartCategories.FindAsync(id);
            if (partCategory == null)
            {
                return NotFound();
            }
            return View(partCategory);
        }

        // POST: PartCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Id,DateCreated,DateModified")] PartCategory partCategory)
        {
            if (id != partCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(partCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PartCategoryExists(partCategory.Id))
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
            return View(partCategory);
        }

        // GET: PartCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PartCategories == null)
            {
                return NotFound();
            }

            var partCategory = await _context.PartCategories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (partCategory == null)
            {
                return NotFound();
            }

            return View(partCategory);
        }

        // POST: PartCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PartCategories == null)
            {
                return Problem("Entity set 'ApplicationDbContext.PartCategories'  is null.");
            }
            var partCategory = await _context.PartCategories.FindAsync(id);
            if (partCategory != null)
            {
                _context.PartCategories.Remove(partCategory);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PartCategoryExists(int id)
        {
          return (_context.PartCategories?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
