using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sunny_Proyecto.Pages.Modelos
{
    public class Datos_Madre
    {
        public int Id { get; set; }
        public string Nombre_Madre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }

        [DataType(DataType.Date)] 
        public string Fecha_Nacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string Ocupacion { get; set; }
        public Int64 Telefono { get; set; }
        public string Domicilio_padres { get; set; }
        public string Municipio { get; set; }
        public string Colonia { get; set; }
        public string Comunidad { get; set; }
        public int Estado_civil { get; set; }
    }
}
