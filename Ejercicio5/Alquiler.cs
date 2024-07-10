using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio5
{
    public class Alquiler
    {
        public Cancha Cancha { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public List<Juez> Jueces { get; set; }

        public Alquiler(Cancha cancha, DateTime inicio, DateTime fin)
        {
            Cancha = cancha;
            Inicio = inicio;
            Fin = fin;
            Jueces = new List<Juez>();
        }

        public bool SeSuperpone(Alquiler otro)
        {
            return Inicio < otro.Fin && Fin > otro.Inicio;
        }
    }
}