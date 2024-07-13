using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    public class Maestra
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Legajo { get; set; }
        public double SueldoBruto { get; set; }
        public bool EsRecibida { get; set; }

        public Maestra(string nombre, string apellido, int legajo, double sueldoBruto, bool esRecibida)
        {
            Nombre = nombre;
            Apellido = apellido;
            Legajo = legajo;
            SueldoBruto = esRecibida ? sueldoBruto : sueldoBruto / 2;
            EsRecibida = esRecibida;
        }

        public override string ToString()
        {
            return $"{Apellido}, {Nombre}";
        }
    }

}
