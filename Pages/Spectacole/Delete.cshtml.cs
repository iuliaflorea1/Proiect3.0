using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect3._0.Data;
using Proiect3._0.Models;

namespace Proiect3._0.Pages.Spectacole
{
    public class DeleteModel : PageModel
    {
        private readonly Proiect3._0.Data.Proiect3_0Context _context;

        public DeleteModel(Proiect3._0.Data.Proiect3_0Context context)
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

            var spectacol = await _context.Spectacol.FirstOrDefaultAsync(m => m.ID == id);

            if (spectacol == null)
            {
                return NotFound();
            }
            else
            {
                Spectacol = spectacol;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spectacol = await _context.Spectacol.FindAsync(id);
            if (spectacol != null)
            {
                Spectacol = spectacol;
                _context.Spectacol.Remove(Spectacol);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
