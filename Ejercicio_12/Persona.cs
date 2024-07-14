using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_12
{
    public class Persona
    {
        public string Nombre { get; set; }


        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public Persona(string pNombre, string pApellido, DateTime pFechaNacimiento) 
        { 
            Nombre = pNombre;
            Apellido = pApellido;
            FechaNacimiento = pFechaNacimiento;
        
        }

    }
}