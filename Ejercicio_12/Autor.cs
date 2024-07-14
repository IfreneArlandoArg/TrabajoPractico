using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_12
{
    public class Autor : Persona
    {
        List<Libro> libros;

        public Autor(string pNombre, string pApellido, DateTime pFechaNacimiento):base(pNombre, pApellido, pFechaNacimiento) 
        { 
        
            libros = new List<Libro>();
        }
    }
}