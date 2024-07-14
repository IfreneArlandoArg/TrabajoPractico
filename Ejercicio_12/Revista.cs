using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_12
{
    public class Revista : Ejemplar
    {
        public string Nombre { get; set; }
        public int Número { get; set; }

        public TipoEntrega tipoEntrega { get; set; }
        public Revista(string pTitulo, Autor pAutor, int pAño, string pEditorial, string pEdición, string pNombre, int pNúmero, TipoEntrega pTipo) : base(pTitulo, pAutor, pAño, pEditorial, pEdición)
        {
            Nombre = pNombre;
            Número = pNúmero;
            tipoEntrega = pTipo;

        }

        public override string ToString()
        {
            return $"{Nombre}, {Número}, tipo entrega : {tipoEntrega}";
        }
    }
}