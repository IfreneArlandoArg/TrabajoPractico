using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    public class Constelacion
    {
        public string Nombre { get; set; }
        public List<Estrella> Estrellas { get; set; }

        public Constelacion(string nombre)
        {
            Nombre = nombre;
            Estrellas = new List<Estrella>();
        }

        public void AgregarEstrella(Estrella estrella)
        {
            Estrellas.Add(estrella);
        }

        // Método para buscar estrellas por tipo (color y tipo de estrella)
        public List<Estrella> BuscarEstrellasPorTipo(ColorEstrella color, TipoEstrella tipo)
        {
            return Estrellas.Where(e => e.Color == color && e.Tipo == tipo).ToList();
        }

        // Método para buscar estrellas por temperatura
        public List<Estrella> BuscarEstrellasPorTemperatura(double temperatura)
        {
            return Estrellas.Where(e => e.TemperaturaCelsius == temperatura).ToList();
        }
    }
}
