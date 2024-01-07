﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using proiect.Data;
using proiect.Models;

namespace proiect.Pages.Stylists
{
    public class DetailsModel : PageModel
    {
        private readonly proiect.Data.proiectContext _context;

        public DetailsModel(proiect.Data.proiectContext context)
        {
            _context = context;
        }

      public Stylist Stylist { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Stylist == null)
            {
                return NotFound();
            }

            var stylist = await _context.Stylist.FirstOrDefaultAsync(m => m.StylistId == id);
            if (stylist == null)
            {
                return NotFound();
            }
            else 
            {
                Stylist = stylist;
            }
            return Page();
        }
    }
}
