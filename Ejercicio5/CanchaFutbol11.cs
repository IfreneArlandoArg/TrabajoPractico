using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio5
{
    public class CanchaFutbol11 : Cancha
    {
        public bool ConArbitro { get; set; }
        public bool ConJuecesDeLinea { get; set; }

        public CanchaFutbol11() : base("Fútbol 11", 800) { }

        public override double CalcularCostoTotal()
        {
            double costoTotal = ValorBase;
            if (ConArbitro) costoTotal += 100;
            if (ConJuecesDeLinea) costoTotal += 90;
            return costoTotal;
        }

        public override double CalcularGananciaPolideportivo()
        {
            double ganancia = ValorBase;
            if (ConArbitro) ganancia += 50;
            if (ConJuecesDeLinea) ganancia += 20; // 2 * 35 - 90
            return ganancia;
        }
    }
}