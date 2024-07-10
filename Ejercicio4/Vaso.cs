using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio4
{
    public class Vaso
    {
        public TipoVaso Tipo { get; set; }
        public double Volumen { get; set; }
        public double Incremento { get; set; }

        public Vaso(TipoVaso tipo)
        {
            Tipo = tipo;
            Incremento = 1.05; // 5% de incremento

            switch (tipo)
            {
                case TipoVaso.Chopp:
                    Volumen = 0.75;
                    break;
                case TipoVaso.Vaso:
                    Volumen = 0.5;
                    break;
                case TipoVaso.Jarra:
                    Volumen = 3.0;
                    break;
            }
        }
    }
}