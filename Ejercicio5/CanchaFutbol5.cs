using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio5
{
    public class CanchaFutbol5 : Cancha
    {
        public CanchaFutbol5() : base("Fútbol 5", 500) { }

        public override double CalcularCostoTotal()
        {
            return ValorBase;
        }

        public override double CalcularGananciaPolideportivo()
        {
            return ValorBase;
        }
    }
}