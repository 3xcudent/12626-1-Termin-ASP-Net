using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Models._12626_1_Termin_ASP_Net;
using _12626_1_Termin_ASP_Net.DAL.Contexts;

namespace _12626_1_Termin_ASP_Net.Controllers
{
    public class AwariasController : Controller
    {
        private readonly AwariaContext _context;

        public AwariasController(AwariaContext context)
        {
            _context = context;
        }

        // GET: Awarias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Awaria.ToListAsync());
        }

        // GET: Awarias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var awaria = await _context.Awaria
                .FirstOrDefaultAsync(m => m.ID == id);
            if (awaria == null)
            {
                return NotFound();
            }

            return View(awaria);
        }

        // GET: Awarias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Awarias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Miejsce,NrUrzadzenia,Opis,Data,Usuniete")] Awaria awaria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(awaria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(awaria);
        }

        // GET: Awarias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var awaria = await _context.Awaria.FindAsync(id);
            if (awaria == null)
            {
                return NotFound();
            }
            return View(awaria);
        }

        // POST: Awarias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Miejsce,NrUrzadzenia,Opis,Data,Usuniete")] Awaria awaria)
        {
            if (id != awaria.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(awaria);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AwariaExists(awaria.ID))
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
            return View(awaria);
        }

        // GET: Awarias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var awaria = await _context.Awaria
                .FirstOrDefaultAsync(m => m.ID == id);
            if (awaria == null)
            {
                return NotFound();
            }

            return View(awaria);
        }

        // POST: Awarias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var awaria = await _context.Awaria.FindAsync(id);
            _context.Awaria.Remove(awaria);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AwariaExists(int id)
        {
            return _context.Awaria.Any(e => e.ID == id);
        }
    }
}
