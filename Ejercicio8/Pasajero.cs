using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    public class Pasajero
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string DNI { get; set; }
        public bool AutorizacionPadres { get; set; } // true si el pasajero es menor y tiene autorización de los padres

        public Pasajero(string nombre, string apellido, DateTime fechaNacimiento, string dni, bool autorizacionPadres)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            DNI = dni;
            AutorizacionPadres = autorizacionPadres;
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido} - DNI: {DNI}, Fecha de Nacimiento: {FechaNacimiento.ToShortDateString()}, Autorización de Padres: {(AutorizacionPadres ? "Sí" : "No")}";
        }
    }
}
