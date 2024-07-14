using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_12
{
    public class LibroConMaterialDigital : Ejemplar
    {
        public int CantCd { get; set; }

        public LibroConMaterialDigital(string pTitulo, Autor pAutor, int pAño, string pEditorial, string pEdición,int pCantCd) : base(pTitulo,pAutor,pAño,pEditorial,pEdición) 
        { 
            CantCd = pCantCd;
        }

        public override string ToString()
        {
            return $"{Titulo}, {Autor.Apellido} {Autor.Apellido}, Editorial : {Editorial}, {Año} con {CantCd} cds.";
        }
    }
}