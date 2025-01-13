using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect3._0.Data;
using Proiect3._0.Models;

namespace Proiect3._0.Pages.Tipuri
{
    public class IndexModel : PageModel
    {
        private readonly Proiect3._0.Data.Proiect3_0Context _context;

        public IndexModel(Proiect3._0.Data.Proiect3_0Context context)
        {
            _context = context;
        }

        public IList<Tip> Tip { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Tip = await _context.Tip.ToListAsync();
        }
    }
}
