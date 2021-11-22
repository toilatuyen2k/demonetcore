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
    public class KhachhangController : Controller
    {
        private readonly MvcMovieContext _context;

        public KhachhangController(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: Khachhang
        public async Task<IActionResult> Index()
        {
            return View(await _context.khachhang.ToListAsync());
        }

        // GET: Khachhang/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachhang = await _context.khachhang
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (khachhang == null)
            {
                return NotFound();
            }

            return View(khachhang);
        }

        // GET: Khachhang/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Khachhang/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("khachhangCode,khachhangFullName,PersonId,PersonCode,PersonFullName")] khachhang khachhang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(khachhang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(khachhang);
        }

        // GET: Khachhang/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachhang = await _context.khachhang.FindAsync(id);
            if (khachhang == null)
            {
                return NotFound();
            }
            return View(khachhang);
        }

        // POST: Khachhang/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("khachhangCode,khachhangFullName,PersonId,PersonCode,PersonFullName")] khachhang khachhang)
        {
            if (id != khachhang.PersonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(khachhang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!khachhangExists(khachhang.PersonId))
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
            return View(khachhang);
        }

        // GET: Khachhang/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachhang = await _context.khachhang
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (khachhang == null)
            {
                return NotFound();
            }

            return View(khachhang);
        }

        // POST: Khachhang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var khachhang = await _context.khachhang.FindAsync(id);
            _context.khachhang.Remove(khachhang);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool khachhangExists(int id)
        {
            return _context.khachhang.Any(e => e.PersonId == id);
        }
    }
}
