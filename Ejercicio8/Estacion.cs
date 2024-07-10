using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    public class Estacion
    {
        public string Nombre { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }

        public Estacion(string nombre, string localidad, string provincia)
        {
            Nombre = nombre;
            Localidad = localidad;
            Provincia = provincia;
        }

        public override string ToString()
        {
            return $"Estación {Nombre} - {Localidad}, {Provincia}";
        }
    }

    // Clase para representar un Viaje
    public class Viaje
    {
        public Estacion Origen { get; set; }
        public Estacion Destino { get; set; }
        public List<Estacion> EstacionesIntermedias { get; set; }
        public double Distancia { get; set; } // en kilómetros
        public double TarifaBase { get; set; } // tarifa base del viaje
        public double VelocidadPromedio { get; set; } // en km/h

        public Viaje(Estacion origen, Estacion destino, List<Estacion> estacionesIntermedias, double distancia, double tarifaBase, double velocidadPromedio)
        {
            Origen = origen;
            Destino = destino;
            EstacionesIntermedias = estacionesIntermedias;
            Distancia = distancia;
            TarifaBase = tarifaBase;
            VelocidadPromedio = velocidadPromedio;
        }

        // Método para calcular el tiempo de viaje en minutos
        public int CalcularTiempoViaje()
        {
            int tiempo = (int)(Distancia / VelocidadPromedio * 60); // en minutos
            tiempo += EstacionesIntermedias.Count * 10; // 10 minutos por cada estación intermedia
            return tiempo;
        }

        // Método para calcular el precio del viaje con descuento por estaciones intermedias
        public double CalcularPrecio()
        {
            double descuento = EstacionesIntermedias.Count * 0.02; // 2% de descuento por cada estación intermedia
            return TarifaBase * (1 - descuento);
        }

        public override string ToString()
        {
            return $"Viaje de {Origen.Nombre} a {Destino.Nombre}, Distancia: {Distancia} km, Tiempo de Viaje: {CalcularTiempoViaje()} minutos, Precio: ${CalcularPrecio()}";
        }
    }
}
