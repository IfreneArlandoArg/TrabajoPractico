using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    public class Atraccion
    {
        public string Nombre { get; set; }
        public List<Animal> Animales { get; set; }
        public double CostoBase { get; set; }
        public int Visitantes { get; set; }

        public Atraccion(string nombre, double costoBase)
        {
            Nombre = nombre;
            Animales = new List<Animal>();
            CostoBase = costoBase;
            Visitantes = 0;
        }

        public void AgregarAnimal(Animal animal)
        {
            Animales.Add(animal);
        }

        public void RegistrarVisita()
        {
            Visitantes++;
        }

        public double CalcularRecaudacion()
        {
            return Visitantes * CostoBase;
        }

        public override string ToString()
        {
            return $"Atracción: {Nombre}, Costo Base: {CostoBase}, Visitantes: {Visitantes}, Recaudación: {CalcularRecaudacion()}";
        }
    }
}
