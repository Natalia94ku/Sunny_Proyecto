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
    public class IndexModel : PageModel
    {
        private readonly Sunny_Proyecto.Models.Sunny_ProyectoContext _context;

        public IndexModel(Sunny_Proyecto.Models.Sunny_ProyectoContext context)
        {
            _context = context;
        }

        public IList<Datos_socioeconomicos> Datos_socioeconomicos { get;set; }

        public async Task OnGetAsync()
        {
            Datos_socioeconomicos = await _context.Datos_socioeconomicos.ToListAsync();
        }
    }
}
