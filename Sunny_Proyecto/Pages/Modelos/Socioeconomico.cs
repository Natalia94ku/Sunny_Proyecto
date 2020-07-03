using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sunny_Proyecto.Pages.Modelos
{
    public class Socioeconomico
    {
        public int Id { get; set; }
        public int Ingresos_Mensuales { get; set; }
        public int Gastos_Alimentos { get; set; }
        public int Gastos_Escolaridad { get; set; }
        public int Gastos_Servicios { get; set; }
        public int Gastos_Transportes { get; set; }
        public int Pago_Vivienda { get; set; }
        public int Otros { get; set; }
    }
}
