using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    public class Maestra
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Legajo { get; set; }
        public decimal SueldoBruto { get; set; }
        public bool EsRecibida { get; set; }

        public Maestra(string nombre, string apellido, string legajo, decimal sueldoBruto, bool esRecibida)
        {
            Nombre = nombre;
            Apellido = apellido;
            Legajo = legajo;
            SueldoBruto = esRecibida ? sueldoBruto : sueldoBruto / 2;
            EsRecibida = esRecibida;
        }
    }

}
