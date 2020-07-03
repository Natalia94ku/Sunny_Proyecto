using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sunny_Proyecto.Models;
using Sunny_Proyecto.Pages.Modelos;

namespace Sunny_Proyecto.Pages.Datos_socioeconomicos_service
{
    public class DeleteModel : PageModel
    {
        private readonly Sunny_Proyecto.Models.Sunny_ProyectoContext _context;

        public DeleteModel(Sunny_Proyecto.Models.Sunny_ProyectoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Datos_socioeconomicos Datos_socioeconomicos { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Datos_socioeconomicos = await _context.Datos_socioeconomicos.FirstOrDefaultAsync(m => m.Id == id);

            if (Datos_socioeconomicos == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Datos_socioeconomicos = await _context.Datos_socioeconomicos.FindAsync(id);

            if (Datos_socioeconomicos != null)
            {
                _context.Datos_socioeconomicos.Remove(Datos_socioeconomicos);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
