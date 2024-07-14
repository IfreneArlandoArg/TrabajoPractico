using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_12
{
    public class Prestamo
    {
        public Cliente ClientePresta { get; set; }
        

        List<Ejemplar> Ejemplares { get; set; }

        public Prestamo(Cliente pClientePresta, List<Ejemplar> pEjemplares) 
        { 
            ClientePresta = pClientePresta;
        
            Ejemplares = pEjemplares;
          
        }

        public override string ToString()
        {
            return $"Prestamo a nombre de {ClientePresta.Nombre}, {Ejemplares.Count} ejemplare(s).";
        }

    }
}