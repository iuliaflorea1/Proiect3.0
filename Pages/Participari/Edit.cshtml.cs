using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proiect3._0.Data;
using Proiect3._0.Models;

namespace Proiect3._0.Pages.Participari
{
    public class EditModel : PageModel
    {
        private readonly Proiect3._0.Data.Proiect3_0Context _context;

        public EditModel(Proiect3._0.Data.Proiect3_0Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Participare Participare { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Participare = await _context.Participare
                .Include(b => b.Spectacol)
                .ThenInclude(b => b.Regizor)
                .Include(b => b.Membru)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (Participare == null)
            {
                return NotFound();
            }

            var spectacolList = _context.Spectacol
                .Include(b => b.Regizor)
                .Select(x => new
                {
                    x.ID,
                    SpectacolFullName = x.Titlu + " - " + x.Regizor.NumeRegizor
                });
            ViewData["SpectacolID"] = new SelectList(spectacolList, "ID", "SpectacolFullName");
            ViewData["MembruID"] = new SelectList(_context.Membru, "ID", "ID", "NumeRegizor");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Participare).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParticipareExists(Participare.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ParticipareExists(int id)
        {
            return _context.Participare.Any(e => e.ID == id);
        }
    }
}
