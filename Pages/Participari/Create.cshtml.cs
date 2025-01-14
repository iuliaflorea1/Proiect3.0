using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect3._0.Data;
using Proiect3._0.Models;
using Microsoft.EntityFrameworkCore;



namespace Proiect3._0.Pages.Participari
{
    public class CreateModel : PageModel
    {
        private readonly Proiect3._0.Data.Proiect3_0Context _context;

        public CreateModel(Proiect3._0.Data.Proiect3_0Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
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

        [BindProperty]
        public Participare Participare { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Participare.Add(Participare);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
