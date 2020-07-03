using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sunny_Proyecto.Models;
using Sunny_Proyecto.Pages.Modelos;

namespace Sunny_Proyecto.Pages.Datos_Madre_service
{
    public class DetailsModel : PageModel
    {
        private readonly Sunny_Proyecto.Models.Sunny_ProyectoContext _context;

        public DetailsModel(Sunny_Proyecto.Models.Sunny_ProyectoContext context)
        {
            _context = context;
        }

        public Datos_Madre Datos_Madre { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Datos_Madre = await _context.Datos_Madre.FirstOrDefaultAsync(m => m.Id == id);

            if (Datos_Madre == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
