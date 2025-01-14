using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proiect3._0.Data;
using Proiect3._0.Models;

namespace Proiect3._0.Pages.Spectacole
{
    [Authorize(Roles = "Admin")]

    public class EditModel : PageModel
    {
        private readonly Proiect3._0.Data.Proiect3_0Context _context;

        public EditModel(Proiect3._0.Data.Proiect3_0Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Spectacol Spectacol { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spectacol =  await _context.Spectacol.FirstOrDefaultAsync(m => m.ID == id);
            if (spectacol == null)
            {
                return NotFound();
            }
            Spectacol = spectacol;
            ViewData["LocatiaID"] = new SelectList(_context.Set<Locatia>(), "ID","DenumireLocatie");
            ViewData["RegizorID"] = new SelectList(_context.Set<Regizor>(), "ID", "NumeRegizor");
            ViewData["TipID"] = new SelectList(_context.Set<Tip>(), "ID","DenumireTip");
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

            _context.Attach(Spectacol).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpectacolExists(Spectacol.ID))
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

        private bool SpectacolExists(int id)
        {
            return _context.Spectacol.Any(e => e.ID == id);
        }
    }
}
