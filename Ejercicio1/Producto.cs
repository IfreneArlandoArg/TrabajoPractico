using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio1
{
    public class Producto
    {
        public string Codigó_Barra { get; set; }
        public string Nombre { get; set; }
        public string Descripción { get; set; }
        public double Precio { get; set; }

        public Producto(string pCodBar, string pNombre, string pDescripcion, double pPrecio) 
        { 
            Codigó_Barra = pCodBar;
            Nombre = pNombre;
            Descripción = pDescripcion;
            Precio = pPrecio;
        
        }
    }
}