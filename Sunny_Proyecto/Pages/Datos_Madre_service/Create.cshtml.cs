﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sunny_Proyecto.Models;
using Sunny_Proyecto.Pages.Modelos;

namespace Sunny_Proyecto.Pages.Datos_Madre_service
{
    public class CreateModel : PageModel
    {
        private readonly Sunny_Proyecto.Models.Sunny_ProyectoContext _context;

        public CreateModel(Sunny_Proyecto.Models.Sunny_ProyectoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Datos_Madre Datos_Madre { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Datos_Madre.Add(Datos_Madre);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}