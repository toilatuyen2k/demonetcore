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
    public class HocsinhController : Controller
    {
        private readonly MvcMovieContext _context;

        public HocsinhController(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: Hocsinh
        public async Task<IActionResult> Index()
        {
            return View(await _context.Hocsinhs.ToListAsync());
        }

        // GET: Hocsinh/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hocsinh = await _context.Hocsinhs
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (hocsinh == null)
            {
                return NotFound();
            }

            return View(hocsinh);
        }

        // GET: Hocsinh/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hocsinh/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Age,PersonId,PersonCode,PersonFullName,Address")] Hocsinh hocsinh)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hocsinh);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hocsinh);
        }

        // GET: Hocsinh/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hocsinh = await _context.Hocsinhs.FindAsync(id);
            if (hocsinh == null)
            {
                return NotFound();
            }
            return View(hocsinh);
        }

        // POST: Hocsinh/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Age,PersonId,PersonCode,PersonFullName,Address")] Hocsinh hocsinh)
        {
            if (id != hocsinh.PersonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hocsinh);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HocsinhExists(hocsinh.PersonId))
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
            return View(hocsinh);
        }

        // GET: Hocsinh/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hocsinh = await _context.Hocsinhs
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (hocsinh == null)
            {
                return NotFound();
            }

            return View(hocsinh);
        }

        // POST: Hocsinh/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hocsinh = await _context.Hocsinhs.FindAsync(id);
            _context.Hocsinhs.Remove(hocsinh);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HocsinhExists(int id)
        {
            return _context.Hocsinhs.Any(e => e.PersonId == id);
        }
    }
}
