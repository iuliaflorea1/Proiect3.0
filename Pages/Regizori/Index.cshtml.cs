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
    public class IndexModel : PageModel
    {
        private readonly Proiect3._0.Data.Proiect3_0Context _context;

        public IndexModel(Proiect3._0.Data.Proiect3_0Context context)
        {
            _context = context;
        }

        public IList<Regizor> Regizor { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Regizor = await _context.Regizor.ToListAsync();
        }
    }
}
