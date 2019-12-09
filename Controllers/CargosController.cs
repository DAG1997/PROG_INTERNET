﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PROJETO_PNET.Data;
using PROJETO_PNET.Models;

namespace PROJETO_PNET.Controllers
{
    public class CargosController : Controller
    {
        private readonly TarefasDbContext _context;

        public CargosController(TarefasDbContext context)
        {
            _context = context;
        }

        // GET: Cargos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cargos.ToListAsync());
        }

        // GET: Cargos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cargos = await _context.Cargos
                .FirstOrDefaultAsync(m => m.CargosId == id);
            if (cargos == null)
            {
                return NotFound();
            }

            return View(cargos);
        }

        // GET: Cargos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cargos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CargosId,NomeCargo,Funcao")] Cargos cargos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cargos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cargos);
        }

        // GET: Cargos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cargos = await _context.Cargos.FindAsync(id);
            if (cargos == null)
            {
                return NotFound();
            }
            return View(cargos);
        }

        // POST: Cargos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CargosId,NomeCargo,Funcao")] Cargos cargos)
        {
            if (id != cargos.CargosId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cargos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CargosExists(cargos.CargosId))
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
            return View(cargos);
        }

        // GET: Cargos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cargos = await _context.Cargos
                .FirstOrDefaultAsync(m => m.CargosId == id);
            if (cargos == null)
            {
                return NotFound();
            }

            return View(cargos);
        }

        // POST: Cargos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cargos = await _context.Cargos.FindAsync(id);
            _context.Cargos.Remove(cargos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CargosExists(int id)
        {
            return _context.Cargos.Any(e => e.CargosId == id);
        }
    }
}
