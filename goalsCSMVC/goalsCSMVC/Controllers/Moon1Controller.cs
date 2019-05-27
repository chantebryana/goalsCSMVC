using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using goalsCSMVC.Models;

namespace goalsCSMVC.Controllers
{
    public class Moon1Controller : Controller
    {
        private readonly goalsCSMVCContext _context;

        public Moon1Controller(goalsCSMVCContext context)
        {
            _context = context;
        }

        // GET: Moon1
        public async Task<IActionResult> Index()
        {
            return View(await _context.Moon1.ToListAsync());
        }

        // GET: Moon1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moon1 = await _context.Moon1
                .SingleOrDefaultAsync(m => m.Id == id);
            if (moon1 == null)
            {
                return NotFound();
            }

            return View(moon1);
        }

        // GET: Moon1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Moon1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FullMoonDate")] Moon1 moon1)
        {
            if (ModelState.IsValid)
            {
                _context.Add(moon1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(moon1);
        }

        // GET: Moon1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moon1 = await _context.Moon1.SingleOrDefaultAsync(m => m.Id == id);
            if (moon1 == null)
            {
                return NotFound();
            }
            return View(moon1);
        }

        // POST: Moon1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullMoonDate")] Moon1 moon1)
        {
            if (id != moon1.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(moon1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Moon1Exists(moon1.Id))
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
            return View(moon1);
        }

        // GET: Moon1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moon1 = await _context.Moon1
                .SingleOrDefaultAsync(m => m.Id == id);
            if (moon1 == null)
            {
                return NotFound();
            }

            return View(moon1);
        }

        // POST: Moon1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var moon1 = await _context.Moon1.SingleOrDefaultAsync(m => m.Id == id);
            _context.Moon1.Remove(moon1);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Moon1Exists(int id)
        {
            return _context.Moon1.Any(e => e.Id == id);
        }
    }
}
