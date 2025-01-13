using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect3._0.Data;
using Proiect3._0.Models;

namespace Proiect3._0.Pages.Regizori
{
    public class DetailsModel : PageModel
    {
        private readonly Proiect3._0.Data.Proiect3_0Context _context;

        public DetailsModel(Proiect3._0.Data.Proiect3_0Context context)
        {
            _context = context;
        }

        public Regizor Regizor { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var regizor = await _context.Regizor.FirstOrDefaultAsync(m => m.ID == id);
            if (regizor == null)
            {
                return NotFound();
            }
            else
            {
                Regizor = regizor;
            }
            return Page();
        }
    }
}
