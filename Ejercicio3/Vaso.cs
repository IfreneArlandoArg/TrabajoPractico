using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio3
{
    public class Vaso
    {
        public TipoVaso Tipo { get; set; }
        public double Volumen { get; set; }

        public Vaso(TipoVaso tipo)
        {
            Tipo = tipo;
            switch (tipo)
            {
                case TipoVaso.Chico:
                    Volumen = 50;
                    break;
                case TipoVaso.Mediano:
                    Volumen = 100;
                    break;
                case TipoVaso.Grande:
                    Volumen = 250;
                    break;
            }
        }
    }
}