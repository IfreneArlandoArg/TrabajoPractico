using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio3
{
    public class Cafe
    {
        public TipoCafe Tipo { get; set; }
        public double PrecioPorLitro { get; set; }

        public Cafe(TipoCafe tipo, double precio)
        {
            Tipo = tipo;
            PrecioPorLitro = precio;
        }
    }
}