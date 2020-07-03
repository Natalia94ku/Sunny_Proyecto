using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sunny_Proyecto.Pages.Modelos
{
    public class Datos_Alumnos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido_paterno { get; set; }
        public string Apellido_materno { get; set; }
        public string curp { get; set; }
        public string Nacionalidad { get; set; }

        [DataType(DataType.Date)] 
        public DateTime Fecha_nacimiento { get; set; }
        public string Genero { get; set; }
        public string Discapacidad { get; set; }
        public int Telefono { get; set; }
        public string Colonia { get; set; }
        public string Direccion { get; set; }
        public string correo_tutor { get; set; }


    }
}
