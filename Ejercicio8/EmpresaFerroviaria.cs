using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    public class EmpresaFerroviaria
    {
        private List<Viaje> viajes;
        private List<Estacion> estaciones;
        private List<Pasaje> pasajes;

        public EmpresaFerroviaria()
        {
            viajes = new List<Viaje>();
            estaciones = new List<Estacion>();
            pasajes = new List<Pasaje>();
        }

        // Método para agregar una estación
        public void AgregarEstacion(Estacion estacion)
        {
            estaciones.Add(estacion);
        }

        // Método para agregar un viaje
        public void AgregarViaje(Viaje viaje)
        {
            viajes.Add(viaje);
        }

        // Método para vender un pasaje
        public void VenderPasaje(Viaje viaje, Pasajero pasajero, CategoriaVagon categoria, int numeroButaca)
        {
            double costoBase = viaje.CalcularPrecio();

            // Aplicar el aumento por categoría de vagon
            switch (categoria)
            {
                case CategoriaVagon.Pullman:
                    costoBase *= 1.1; // 10% más caro que turista
                    break;
                case CategoriaVagon.Ejecutivo:
                    costoBase *= 1.07; // 7% más caro que pullman
                    break;
                default:
                    break;
            }

            Pasaje pasaje = new Pasaje(viaje, pasajero, categoria, numeroButaca, costoBase);
            pasajes.Add(pasaje);
        }

        // Método para obtener la recaudación total de la empresa
        public double ObtenerRecaudacionTotal()
        {
            return pasajes.Sum(p => p.CostoTotal);
        }

        // Método para obtener la recaudación discriminada por rutas y/o por categorías
        public double ObtenerRecaudacionPorRutasYCategorias(Estacion origen, Estacion destino, CategoriaVagon categoria)
        {
            return pasajes.Where(p => p.Viaje.Origen == origen && p.Viaje.Destino == destino && p.Categoria == categoria)
                          .Sum(p => p.CostoTotal);
        }

        // Método para obtener la cantidad total de pasajeros
        public int ObtenerCantidadTotalPasajeros()
        {
            return pasajes.Count;
        }

        // Método para obtener la cantidad de pasajeros discriminado por rutas y/o por categorías
        public int ObtenerCantidadPasajerosPorRutasYCategorias(Estacion origen, Estacion destino, CategoriaVagon categoria)
        {
            return pasajes.Count(p => p.Viaje.Origen == origen && p.Viaje.Destino == destino && p.Categoria == categoria);
        }

        // Método para verificar si hay lugares disponibles en una formación para un viaje específico
        public bool HayLugaresDisponibles(Viaje viaje, CategoriaVagon categoria)
        {
            // Suponiendo que se tiene un sistema para manejar los asientos disponibles en cada viaje y categoría de vagon
            // Aquí se simularía la verificación de disponibilidad de asientos en la formación para el viaje y categoría especificados
            return true; // Implementar lógica real según la estructura de datos de la formación
        }
    }
}
