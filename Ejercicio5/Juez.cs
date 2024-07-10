using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio5
{
    public class Juez
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Legajo { get; set; }
        public double Ganancia { get; set; }
        public int PartidosDirigidos { get; set; }

        public Juez(string nombre, string apellido, string legajo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Legajo = legajo;
            Ganancia = 0;
            PartidosDirigidos = 0;
        }

        public void AgregarPartido(double ganancia)
        {
            Ganancia += ganancia;
            PartidosDirigidos++;
        }
    }
}