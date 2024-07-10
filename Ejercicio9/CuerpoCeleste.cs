using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    public abstract class CuerpoCeleste
    {
        public DateTime FechaEncuentro { get; set; }
        public Persona Observador { get; set; }
        public double DistanciaAniosLuz { get; set; }
        public string Nombre { get; set; }

        protected CuerpoCeleste(DateTime fechaEncuentro, Persona observador, double distanciaAniosLuz, string nombre)
        {
            FechaEncuentro = fechaEncuentro;
            Observador = observador;
            DistanciaAniosLuz = distanciaAniosLuz;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Fecha Encuentro: {FechaEncuentro.ToShortDateString()}, Observador: {Observador}, Distancia: {DistanciaAniosLuz} años luz";
        }
    }
}
