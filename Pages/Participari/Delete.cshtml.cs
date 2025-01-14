using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect3._0.Data;
using Proiect3._0.Models;

namespace Proiect3._0.Pages.Participari
{
    public class DeleteModel : PageModel
    {
        private readonly Proiect3._0.Data.Proiect3_0Context _context;

        public DeleteModel(Proiect3._0.Data.Proiect3_0Context context)
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

            var participare = await _context.Participare.FirstOrDefaultAsync(m => m.ID == id);

            if (participare == null)
            {
                return NotFound();
            }
            else
            {
                Participare = participare;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var participare = await _context.Participare.FindAsync(id);
            if (participare != null)
            {
                Participare = participare;
                _context.Participare.Remove(Participare);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
