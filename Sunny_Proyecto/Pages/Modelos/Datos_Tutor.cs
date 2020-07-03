using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sunny_Proyecto.Pages.Modelos
{
    public class Datos_Tutor
    {
        public int Id { get; set; }
        public string Nombre_tutor { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }

        [DataType(DataType.Date)]
        public int Fecha_Nacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string Ocupacion { get; set; }
        public int Ingreso { get; set; }
        public Int64 Telefono { get; set; }

    }
}
