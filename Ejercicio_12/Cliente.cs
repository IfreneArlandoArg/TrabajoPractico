using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_12
{
    public class Cliente : Persona
    {
        public bool PrimeraVez { get; set; }
        public Cliente(string pNombre, string pApellido, DateTime pFechaNacimiento, bool pPrimeraVez) : base(pNombre, pApellido, pFechaNacimiento)  
        { 
            PrimeraVez = pPrimeraVez;
        
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}