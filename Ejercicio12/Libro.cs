using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    public class Libro : Ejemplar
    {
        public Libro(int id, string titulo, string autor, int ano, string editorial, int edicion)
            : base(id, titulo, autor, ano, editorial, edicion)
        {
        }
    }

}
