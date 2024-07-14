using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_12
{
    public class Ejemplar
    {
        public string Titulo { get; set; }
        public Autor Autor { get; set; }

        public int Año { get; set; }

        public string Editorial { get; set; }
        public string Edición { get; set; }

        public Ejemplar(string pTitulo, Autor pAutor, int pAño, string pEditorial, string pEdición) 
        { 
           Titulo = pTitulo;
           Autor = pAutor;
           Año = pAño;
           Editorial = pEditorial;
           Edición = pEdición;

        }

        
    }
}