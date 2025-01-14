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
    public class DetailsModel : PageModel
    {
        private readonly Proiect3._0.Data.Proiect3_0Context _context;

        public DetailsModel(Proiect3._0.Data.Proiect3_0Context context)
        {
            _context = context;
        }

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
    }
}
