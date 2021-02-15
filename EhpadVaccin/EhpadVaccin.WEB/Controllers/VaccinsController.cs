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
    public class VaccinsController : Controller
    {
        private readonly Contexte _context = new Contexte();

        //public VaccinController(Contexte context)
        //{
        //    _context = context;   
        //}

        // GET: Vaccin
        public async Task<IActionResult> Index()
        {
            return View(await _context.Vaccins.ToListAsync());
        }

        // GET: Vaccin/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vaccin = await _context.Vaccins
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vaccin == null)
            {
                return NotFound();
            }

            return View(vaccin);
        }

        // GET: Vaccin/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vaccin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nom")] Vaccin vaccin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vaccin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vaccin);
        }

        // GET: Vaccin/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vaccin = await _context.Vaccins.FindAsync(id);
            if (vaccin == null)
            {
                return NotFound();
            }
            return View(vaccin);
        }

        // POST: Vaccin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nom")] Vaccin vaccin)
        {
            if (id != vaccin.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vaccin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VaccinExists(vaccin.Id))
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
            return View(vaccin);
        }

        // GET: Vaccin/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vaccin = await _context.Vaccins
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vaccin == null)
            {
                return NotFound();
            }

            return View(vaccin);
        }

        // POST: Vaccin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vaccin = await _context.Vaccins.FindAsync(id);
            _context.Vaccins.Remove(vaccin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VaccinExists(int id)
        {
            return _context.Vaccins.Any(e => e.Id == id);
        }
    }
}
