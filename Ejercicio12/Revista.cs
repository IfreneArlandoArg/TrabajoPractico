using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    public class Revista : Ejemplar
    {
        public int Numero { get; set; }
        public string TipoEntrega { get; set; }

        public Revista(int id, string titulo, string autor, int ano, string editorial, int edicion, int numero, string tipoEntrega)
            : base(id, titulo, autor, ano, editorial, edicion)
        {
            Numero = numero;
            TipoEntrega = tipoEntrega;
        }
    }

}
