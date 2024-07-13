using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    public class Estudio
    {
        public string Nombre { get; set; }
        public decimal Costo { get; set; }
        public int CupoDiario { get; set; }

        public Estudio(string pNombre, decimal pCosto, int pCupoDiario) 
        { 
          Nombre = pNombre;
          Costo = pCosto;
          CupoDiario = pCupoDiario;
        }
    }

}
