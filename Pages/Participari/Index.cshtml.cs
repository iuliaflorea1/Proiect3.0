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
    public class IndexModel : PageModel
    {
        private readonly Proiect3._0.Data.Proiect3_0Context _context;

        public IndexModel(Proiect3._0.Data.Proiect3_0Context context)
        {
            _context = context;
        }

        public IList<Participare> Participare { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Participare = await _context.Participare
                .Include(p => p.Membru)
                .Include(p => p.Spectacol)
                    .ThenInclude(b => b.Regizor)
                .ToListAsync();
        }
    }
}
