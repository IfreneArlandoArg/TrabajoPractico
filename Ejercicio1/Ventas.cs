using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio1
{
    public class Ventas
    {
        List<Venta> lstVentas = new List<Venta>();

        public void AgregarVenta(Venta pVenta) 
        { 
          lstVentas.Add(pVenta);
        }

        public List<Venta> getVentas() 
        { 
          return lstVentas;
        }
        public double RecaudacionTotal() 
        {
          double total = 0;

          foreach(Venta venta in lstVentas) 
          {
                total += venta.SubTotal();
          }

          return total;
        }
    }
}