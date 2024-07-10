using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    public class Planeta : CuerpoCeleste
    {
        public double Masa { get; set; }
        public double Edad { get; set; }
        public double Temperatura { get; set; }
        public List<Satelite> Satelites { get; set; }
        public Estrella EstrellaOrbita { get; set; }
        public double DistanciaEstrella { get; set; }
        public bool EsZonaRicitosDeOro { get; set; }
        public bool EsPotencialmenteHabitable { get; set; }

        public Planeta(DateTime fechaEncuentro, Persona observador, double distanciaAniosLuz, string nombre,
                       double masa, double edad, double temperatura)
            : base(fechaEncuentro, observador, distanciaAniosLuz, nombre)
        {
            Masa = masa;
            Edad = edad;
            Temperatura = temperatura;
            Satelites = new List<Satelite>();
        }

        public override string ToString()
        {
            return base.ToString() + $", Masa: {Masa}, Edad: {Edad} años, Temperatura: {Temperatura} °C, Estrella que orbita: {EstrellaOrbita?.Nombre}, Distancia a la estrella: {DistanciaEstrella} años luz, Zona Ricitos de Oro: {EsZonaRicitosDeOro}, Potencialmente habitable: {EsPotencialmenteHabitable}, Satélites: {Satelites.Count}";
        }
    }
}
