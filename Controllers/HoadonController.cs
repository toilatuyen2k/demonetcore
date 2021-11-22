using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoNetcore.Data;
using DemoNetcore.Models;

namespace DemoNetcore.Controllers
{
    public class HoadonController : Controller
    {
        private readonly MvcMovieContext _context;

        public HoadonController(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: Hoadon
        public async Task<IActionResult> Index()
        {
            var mvcMovieContext = _context.hoadon.Include(h => h.Person);
            return View(await mvcMovieContext.ToListAsync());
        }

        // GET: Hoadon/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoadon = await _context.hoadon
                .Include(h => h.Person)
                .FirstOrDefaultAsync(m => m.hoadonId == id);
            if (hoadon == null)
            {
                return NotFound();
            }

            return View(hoadon);
        }

        // GET: Hoadon/Create
        public IActionResult Create()
        {
            ViewData["PersonId"] = new SelectList(_context.Person, "PersonId", "PersonId");
            return View();
        }

        // POST: Hoadon/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("hoadonId,PersonId,hoadonCode,hoadonFullName")] hoadon hoadon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hoadon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PersonId"] = new SelectList(_context.Person, "PersonId", "PersonId", hoadon.PersonId);
            return View(hoadon);
        }

        // GET: Hoadon/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoadon = await _context.hoadon.FindAsync(id);
            if (hoadon == null)
            {
                return NotFound();
            }
            ViewData["PersonId"] = new SelectList(_context.Person, "PersonId", "PersonId", hoadon.PersonId);
            return View(hoadon);
        }

        // POST: Hoadon/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("hoadonId,PersonId,hoadonCode,hoadonFullName")] hoadon hoadon)
        {
            if (id != hoadon.hoadonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hoadon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!hoadonExists(hoadon.hoadonId))
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
            ViewData["PersonId"] = new SelectList(_context.Person, "PersonId", "PersonId", hoadon.PersonId);
            return View(hoadon);
        }

        // GET: Hoadon/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoadon = await _context.hoadon
                .Include(h => h.Person)
                .FirstOrDefaultAsync(m => m.hoadonId == id);
            if (hoadon == null)
            {
                return NotFound();
            }

            return View(hoadon);
        }

        // POST: Hoadon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hoadon = await _context.hoadon.FindAsync(id);
            _context.hoadon.Remove(hoadon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool hoadonExists(int id)
        {
            return _context.hoadon.Any(e => e.hoadonId == id);
        }
    }
}
