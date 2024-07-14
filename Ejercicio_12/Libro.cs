using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_12
{
    public class Libro : Ejemplar
    {
        public Libro(string pTitulo, Autor pAutor, int pAño, string pEditorial, string pEdición): base(pTitulo,pAutor, pAño,pEditorial,pEdición) 
        { 
        
        }

        public override string ToString()
        {
            return $"{Titulo}, {Autor.Apellido} {Autor.Apellido}, Editorial : {Editorial}, {Año}.";
        }
    }
}