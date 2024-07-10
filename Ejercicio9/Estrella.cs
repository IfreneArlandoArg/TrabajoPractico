using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    public class Estrella : CuerpoCeleste
    {
        public double Masa { get; set; }
        public double TemperaturaCelsius { get; set; }
        public double Edad { get; set; }
        public double Diametro { get; set; }
        public ColorEstrella Color { get; set; }
        public TipoEstrella Tipo { get; set; }

        public Estrella(DateTime fechaEncuentro, Persona observador, double distanciaAniosLuz, string nombre,
                        double masa, double temperaturaCelsius, double edad, double diametro,
                        ColorEstrella color, TipoEstrella tipo)
            : base(fechaEncuentro, observador, distanciaAniosLuz, nombre)
        {
            Masa = masa;
            TemperaturaCelsius = temperaturaCelsius;
            Edad = edad;
            Diametro = diametro;
            Color = color;
            Tipo = tipo;
        }

        public override string ToString()
        {
            return base.ToString() + $", Masa: {Masa}, Temperatura: {TemperaturaCelsius} °C, Edad: {Edad} años, Diametro: {Diametro}, Color: {Color}, Tipo: {Tipo}";
        }
    }
}
