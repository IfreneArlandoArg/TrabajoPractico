using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio2
{
    public class Venta
    {
        public int CantidadEnLitro { get; set; }
        public string Tipo { get; set; }

        public double Precio { get; set; }

        public Venta(int pCant, string pTipo) 
        { 
            CantidadEnLitro = pCant;
            Tipo = pTipo;
            Precio = CalcularPrecio(pCant, pTipo);
        
        }

        double CalcularPrecio(int cant, string pTipo) 
        {
            double precioPorLitro = 0;

            if (pTipo == "Normal")
                precioPorLitro = 17.20;
            if (pTipo == "Súper")
                precioPorLitro = 18.85;
            if (pTipo == "Premium")
                precioPorLitro = 21.30;

            return cant * precioPorLitro;
        }


    }
}