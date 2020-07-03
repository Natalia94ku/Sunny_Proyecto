using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sunny_Proyecto.Pages.Modelos;

namespace Sunny_Proyecto.Models
{
    public class Sunny_ProyectoContext : DbContext
    {
        public Sunny_ProyectoContext (DbContextOptions<Sunny_ProyectoContext> options)
            : base(options)
        {
        }

        public DbSet<Sunny_Proyecto.Pages.Modelos.Datos_Alumnos> Datos_Alumnos { get; set; }

        public DbSet<Sunny_Proyecto.Pages.Modelos.Datos_Academicos> Datos_Academicos { get; set; }

        public DbSet<Sunny_Proyecto.Pages.Modelos.Datos_Tutor> Datos_Tutor { get; set; }

        public DbSet<Sunny_Proyecto.Pages.Modelos.Datos_Madre> Datos_Madre { get; set; }

        public DbSet<Sunny_Proyecto.Pages.Modelos.Socioeconomico> Socioeconomico { get; set; }

        public DbSet<Sunny_Proyecto.Pages.Modelos.Datos_socioeconomicos> Datos_socioeconomicos { get; set; }
    }
}
