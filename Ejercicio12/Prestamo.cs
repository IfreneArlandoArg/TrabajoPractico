using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    using System;

    public class Prestamo
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Ejemplar Ejemplar { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }

        public Prestamo(int id, Cliente cliente, Ejemplar ejemplar, DateTime fechaPrestamo)
        {
            Id = id;
            Cliente = cliente;
            Ejemplar = ejemplar;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = fechaPrestamo.AddDays(5);
        }

        public bool EsTarde()
        {
            return DateTime.Now > FechaDevolucion;
        }
    }

}
