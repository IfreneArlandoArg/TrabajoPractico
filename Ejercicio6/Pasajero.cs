using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    public class Pasajero
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string DNI { get; set; }
        public int Edad { get; set; }

        public Pasajero(string nombre, string apellido, DateTime fechaNacimiento, string dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            DNI = dni;
            Edad = DateTime.Now.Year - fechaNacimiento.Year;
        }
    }
}
