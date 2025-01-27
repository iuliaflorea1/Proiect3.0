﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect3._0.Data;
using Proiect3._0.Models;

namespace Proiect3._0.Pages.Spectacole
{
    [Authorize(Roles = "Admin")]
    public class CreateModel : PageModel
    {
        private readonly Proiect3._0.Data.Proiect3_0Context _context;

        public CreateModel(Proiect3._0.Data.Proiect3_0Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["LocatiaID"] = new SelectList(_context.Set<Locatia>(), "ID","DenumireLocatie");
            ViewData["RegizorID"] = new SelectList(_context.Set<Regizor>(), "ID","NumeRegizor");
            ViewData["TipID"] = new SelectList(_context.Set<Tip>(), "ID","DenumireTip");
            return Page();
        }

        [BindProperty]
        public Spectacol Spectacol { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Spectacol.Add(Spectacol);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
