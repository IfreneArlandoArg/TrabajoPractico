using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    public class Satelite : CuerpoCeleste
    {
        public bool AcoplamientoMarea { get; set; }
        public double Masa { get; set; }
        public double Edad { get; set; }

        public Satelite(DateTime fechaEncuentro, Persona observador, double distanciaAniosLuz, string nombre,
                        bool acoplamientoMarea, double masa, double edad)
            : base(fechaEncuentro, observador, distanciaAniosLuz, nombre)
        {
            AcoplamientoMarea = acoplamientoMarea;
            Masa = masa;
            Edad = edad;
        }

        public override string ToString()
        {
            return base.ToString() + $", Acoplamiento de marea: {AcoplamientoMarea}, Masa: {Masa}, Edad: {Edad} años";
        }
    }
}
