using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    public class Museo
    {
        private List<Atraccion> atracciones;
        private List<Pasaporte> pasaportes;
        private List<Animal> animales;

        public Museo()
        {
            atracciones = new List<Atraccion>();
            pasaportes = new List<Pasaporte>();
            animales = new List<Animal>();
        }

        public void AgregarAtraccion(Atraccion atraccion)
        {
            atracciones.Add(atraccion);
        }

        public void AgregarAnimal(Animal animal)
        {
            animales.Add(animal);
        }

        public void RegistrarPasaporte(Pasaporte pasaporte)
        {
            pasaportes.Add(pasaporte);
        }

        public double CalcularRecaudacionTotal()
        {
            return pasaportes.Sum(p => p.CalcularCostoTotal());
        }

        public Atraccion ObtenerAtraccionMasVisitada()
        {
            return atracciones.OrderByDescending(a => a.Visitantes).FirstOrDefault();
        }

        public Atraccion ObtenerAtraccionMayorRecaudacion()
        {
            return atracciones.OrderByDescending(a => a.CalcularRecaudacion()).FirstOrDefault();
        }

        public List<Animal> BuscarAnimalPorNombre(string nombre)
        {
            return animales.Where(a => a.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Animal> BuscarAnimalesPorPeriodo(int desde, int hasta)
        {
            return animales.Where(a => a.PeriodoExistencia >= desde && a.PeriodoExistencia <= hasta).ToList();
        }

        public List<Animal> BuscarAnimalesPorPeriodoYSector(int desde, int hasta, string sector)
        {
            var atraccion = atracciones.FirstOrDefault(a => a.Nombre.Equals(sector, StringComparison.OrdinalIgnoreCase));
            if (atraccion != null)
            {
                return atraccion.Animales.Where(a => a.PeriodoExistencia >= desde && a.PeriodoExistencia <= hasta).ToList();
            }
            return new List<Animal>();
        }

        public override string ToString()
        {
            return $"Museo con {atracciones.Count} atracciones, {pasaportes.Count} pasaportes vendidos y {animales.Count} animales registrados.";
        }
    }
}
