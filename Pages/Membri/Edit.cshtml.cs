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

namespace Proiect3._0.Pages.Membri
{
    public class EditModel : PageModel
    {
        private readonly Proiect3._0.Data.Proiect3_0Context _context;

        public EditModel(Proiect3._0.Data.Proiect3_0Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Membru Membru { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membru =  await _context.Membru.FirstOrDefaultAsync(m => m.ID == id);
            if (membru == null)
            {
                return NotFound();
            }
            Membru = membru;
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

            _context.Attach(Membru).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MembruExists(Membru.ID))
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

        private bool MembruExists(int id)
        {
            return _context.Membru.Any(e => e.ID == id);
        }
    }
}
