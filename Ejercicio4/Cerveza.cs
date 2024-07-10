using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio4
{
    public class Cerveza
    {
        public TipoCerveza Tipo { get; set; }
        public double PrecioPorLitro { get; set; }

        public Cerveza(TipoCerveza tipo, double precio)
        {
            Tipo = tipo;
            PrecioPorLitro = precio;
        }
    }
}