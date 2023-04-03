using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BrailleTestApp.Data;
using BrailleTestApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace BrailleTestApp.Controllers
{
    public class BraillesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BraillesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Brailles
        public async Task<IActionResult> Index()
        {
              return _context.Braille != null ? 
                          View(await _context.Braille.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Braille'  is null.");
        }
        //some code to search braille
        //GET: Brailles/SearchForm
        public async Task<IActionResult> SearchForm()
        {
            return View();
        }

        //some code to get braille for what searched
        //GET: Brailles/SearchForm
        public async Task<IActionResult> SearchResults()
        {
            return View();
        }

        //im making some code to get searchresults
        // POST: Brailles/SearchResults
        public async Task<IActionResult> SearchResult(String SearchedShape)
        {
            return View("Index", await _context.Braille.Where(j => j.Pattern.Contains(SearchedShape)).ToListAsync());
        }

        // GET: Brailles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Braille == null)
            {
                return NotFound();
            }

            var braille = await _context.Braille
                .FirstOrDefaultAsync(m => m.Id == id);
            if (braille == null)
            {
                return NotFound();
            }

            return View(braille);
        }

        // GET: Brailles/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Brailles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Shape,Pattern")] Braille braille)
        {
            if (ModelState.IsValid)
            {
                _context.Add(braille);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(braille);
        }

        // GET: Brailles/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Braille == null)
            {
                return NotFound();
            }

            var braille = await _context.Braille.FindAsync(id);
            if (braille == null)
            {
                return NotFound();
            }
            return View(braille);
        }

        // POST: Brailles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Shape,Pattern")] Braille braille)
        {
            if (id != braille.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(braille);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BrailleExists(braille.Id))
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
            return View(braille);
        }

        // GET: Brailles/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Braille == null)
            {
                return NotFound();
            }

            var braille = await _context.Braille
                .FirstOrDefaultAsync(m => m.Id == id);
            if (braille == null)
            {
                return NotFound();
            }

            return View(braille);
        }

        // POST: Brailles/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Braille == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Braille'  is null.");
            }
            var braille = await _context.Braille.FindAsync(id);
            if (braille != null)
            {
                _context.Braille.Remove(braille);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BrailleExists(int id)
        {
          return (_context.Braille?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
