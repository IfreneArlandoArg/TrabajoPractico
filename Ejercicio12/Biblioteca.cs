using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Biblioteca
    {
        public List<Cliente> Clientes { get; set; }
        public List<Ejemplar> Ejemplares { get; set; }
        public List<Prestamo> Prestamos { get; set; }

        public Biblioteca()
        {
            Clientes = new List<Cliente>();
            Ejemplares = new List<Ejemplar>();
            Prestamos = new List<Prestamo>();
        }

        public bool RegistrarPrestamo(int clienteId, int ejemplarId)
        {
            var cliente = Clientes.Find(c => c.Id == clienteId);
            var ejemplar = Ejemplares.Find(e => e.Id == ejemplarId);

            if (cliente == null || ejemplar == null || !cliente.PuedePrestar())
                return false;

            var prestamosCliente = Prestamos.Count(p => p.Cliente.Id == clienteId && !p.EsTarde());

            if (prestamosCliente >= 3 || (prestamosCliente >= 1 && Prestamos.Any(p => p.Cliente.Id == clienteId && p.EsTarde())))
                return false;

            var prestamo = new Prestamo(Prestamos.Count + 1, cliente, ejemplar, DateTime.Now);
            Prestamos.Add(prestamo);
            cliente.Prestamos.Add(prestamo);

            return true;
        }

        public void RegistrarDevolucion(int prestamoId)
        {
            var prestamo = Prestamos.Find(p => p.Id == prestamoId);

            if (prestamo == null)
                return;

            if (prestamo.EsTarde())
            {
                prestamo.Cliente.Sanciones++;
                switch (prestamo.Cliente.Sanciones)
                {
                    case 1:
                        prestamo.Cliente.FechaFinSancion = DateTime.Now.AddDays(7);
                        break;
                    case 2:
                        prestamo.Cliente.FechaFinSancion = DateTime.Now.AddDays(30);
                        break;
                    case 3:
                        prestamo.Cliente.FechaFinSancion = null;
                        // Aquí se debe gestionar el pago de la multa.
                        break;
                }
            }
            prestamo.Cliente.Prestamos.Remove(prestamo);
            Prestamos.Remove(prestamo);
        }
    }

}
