﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sunny_Proyecto.Models;
using Sunny_Proyecto.Pages.Modelos;

namespace Sunny_Proyecto.Pages.Datos_Tutor_service
{
    public class EditModel : PageModel
    {
        private readonly Sunny_Proyecto.Models.Sunny_ProyectoContext _context;

        public EditModel(Sunny_Proyecto.Models.Sunny_ProyectoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Datos_Tutor Datos_Tutor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Datos_Tutor = await _context.Datos_Tutor.FirstOrDefaultAsync(m => m.Id == id);

            if (Datos_Tutor == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Datos_Tutor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Datos_TutorExists(Datos_Tutor.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool Datos_TutorExists(int id)
        {
            return _context.Datos_Tutor.Any(e => e.Id == id);
        }
    }
}
