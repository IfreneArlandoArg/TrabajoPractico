using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool TieneHermanoEnEstablecimiento { get; set; }

        public Alumno(string nombre, string apellido, DateTime fechaNacimiento, bool tieneHermanoEnEstablecimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            TieneHermanoEnEstablecimiento = tieneHermanoEnEstablecimiento;
        }
    }

}
