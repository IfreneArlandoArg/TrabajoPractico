using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    public abstract class Ejemplar
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }
        public string Editorial { get; set; }
        public int Edicion { get; set; }

        public Ejemplar(int id, string titulo, string autor, int ano, string editorial, int edicion)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            Ano = ano;
            Editorial = editorial;
            Edicion = edicion;
        }
    }

}
