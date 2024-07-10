using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio5
{
    public abstract class Cancha
    {
        public string Nombre { get; set; }
        public double ValorBase { get; set; }
        public List<Juez> Jueces { get; set; }

        public int CantVecesAlquilada { get; set; }

        protected Cancha(string nombre, double valorBase)
        {
            Nombre = nombre;
            ValorBase = valorBase;
            Jueces = new List<Juez>();
            CantVecesAlquilada ++;
        }

        public abstract double CalcularCostoTotal();
        public abstract double CalcularGananciaPolideportivo();
    }
}