using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EhpadVaccin.ORM;

namespace EhpadVaccin.WEB.Controllers
{
    public class InjectionsController : Controller
    {
        private readonly Contexte _context = new Contexte();

        //public InjectionController(Contexte context)
        //{
        //    _context = context;   
        //}

        // GET: Injection
        public async Task<IActionResult> Index()
        {
            return View(await _context.Injections.ToListAsync());
        }

        // GET: Injection/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var injection = await _context.Injections
                .FirstOrDefaultAsync(m => m.Id == id);
            if (injection == null)
            {
                return NotFound();
            }

            return View(injection);
        }

        // GET: Injection/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Injection/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,dateInjection,dateRappel,numLot,marque")] Injection injection)
        {
            if (ModelState.IsValid)
            {
                _context.Add(injection);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(injection);
        }

        // GET: Injection/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var injection = await _context.Injections.FindAsync(id);
            if (injection == null)
            {
                return NotFound();
            }
            return View(injection);
        }

        // POST: Injection/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,dateInjection,dateRappel,numLot,marque")] Injection injection)
        {
            if (id != injection.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(injection);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InjectionExists(injection.Id))
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
            return View(injection);
        }

        // GET: Injection/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var injection = await _context.Injections
                .FirstOrDefaultAsync(m => m.Id == id);
            if (injection == null)
            {
                return NotFound();
            }

            return View(injection);
        }

        // POST: Injection/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var injection = await _context.Injections.FindAsync(id);
            _context.Injections.Remove(injection);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InjectionExists(int id)
        {
            return _context.Injections.Any(e => e.Id == id);
        }
    }
}
