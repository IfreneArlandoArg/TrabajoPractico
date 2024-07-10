using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Legajo { get; set; }

        public Persona(string nombre, string apellido, DateTime fechaNacimiento, string legajo)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Legajo = legajo;
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido} (Legajo: {Legajo})";
        }
    }

}
