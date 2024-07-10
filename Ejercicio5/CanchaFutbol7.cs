using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio5
{
    public class CanchaFutbol7 : Cancha
    {
        public bool ConArbitro { get; set; }
        

        public CanchaFutbol7() : base("Fútbol 7", 650) 
        { 
           
        }

        public override double CalcularCostoTotal()
        {
            return ConArbitro ? ValorBase + 100 : ValorBase;
        }

        public override double CalcularGananciaPolideportivo()
        {
            return ConArbitro ? ValorBase + 50 : ValorBase;
        }
    }
}