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
    public class ProfessoresController : Controller
    {
        private readonly TarefasDbContext _context;

        public ProfessoresController(TarefasDbContext context)
        {
            _context = context;
        }

        // GET: Professores
        public async Task<IActionResult> Index(String sortOrder, string searchString, string currentFilter, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["CurrentFilter"] = searchString;

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var tarefasDbContext = from s in _context.Professores
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                tarefasDbContext = tarefasDbContext.Where(s => s.Nome.Contains(searchString));
                                       
            }
            switch (sortOrder)
            {
                case "name_desc":
                    tarefasDbContext = tarefasDbContext.OrderByDescending(s => s.Nome);
                    break;
                case "numero":
                    tarefasDbContext = tarefasDbContext.OrderByDescending(s => s.Numero);
                    break;
                case "email":
                    tarefasDbContext = tarefasDbContext.OrderByDescending(s => s.Email);
                    break;
                default:
                    tarefasDbContext = tarefasDbContext.OrderBy(s => s.Nome);
                    break;
            }
            int pageSize = 3;
            return View(await PaginatedList<Professores>.CreateAsync(tarefasDbContext.AsNoTracking(), pageNumber ?? 1, pageSize));
    }

        // GET: Professores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professores = await _context.Professores
                .FirstOrDefaultAsync(m => m.professoresId == id);
            if (professores == null)
            {
                return NotFound();
            }

            return View(professores);
        }

        // GET: Professores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Professores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("professoresId,Nome,Numero,Email")] Professores professores)
        {
            if (ModelState.IsValid)
            {
                _context.Add(professores);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(professores);
        }

        // GET: Professores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professores = await _context.Professores.FindAsync(id);
            if (professores == null)
            {
                return NotFound();
            }
            return View(professores);
        }

        // POST: Professores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("professoresId,Nome,Numero,Email")] Professores professores)
        {
            if (id != professores.professoresId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(professores);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfessoresExists(professores.professoresId))
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
            return View(professores);
        }

        // GET: Professores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professores = await _context.Professores
                .FirstOrDefaultAsync(m => m.professoresId == id);
            if (professores == null)
            {
                return NotFound();
            }

            return View(professores);
        }

        // POST: Professores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var professores = await _context.Professores.FindAsync(id);
            _context.Professores.Remove(professores);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfessoresExists(int id)
        {
            return _context.Professores.Any(e => e.professoresId == id);
        }
    }
}
