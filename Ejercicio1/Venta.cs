using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio1
{
    public class Venta
    {
        List<Producto> lstProductos = new List<Producto>();

        public void AgregarProducto(Producto p) 
        { 
          lstProductos.Add(p);
        }

        public void BorrarProducto(Producto p) 
        { 
          lstProductos.Remove(p);
        }

        public void CancelarVenta() 
        { 
         lstProductos.Clear();
        }

        public List<Producto> GetProductos()
        {
            return lstProductos;
        }
        public double SubTotal()
        {
            double total = 0;

            foreach (Producto producto in lstProductos) 
            {
                total += producto.Precio;
            }

            return total;
        }

        public override string ToString() 
        {
            return $"{lstProductos.Count} items - Subtotal : {SubTotal()}";        
        }
    }
}