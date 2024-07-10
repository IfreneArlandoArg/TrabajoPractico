using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    
    public class GestorCuotas : IGestorCuotas
    {
        private List<Cuota> cuotas;
        private List<Maestra> maestras;

        public GestorCuotas(List<Maestra> maestras)
        {
            cuotas = new List<Cuota>();
            this.maestras = maestras;
        }

        public void GestionarCobroCuotas()
        {
            foreach (var cuota in cuotas)
            {
                if (!cuota.Pagada)
                {
                    cuota.Pagada = true;
                }
            }
        }

        public decimal CalcularRecaudacionMensual()
        {
            return cuotas.Where(c => c.FechaPago.Month == DateTime.Now.Month && c.Pagada).Sum(c => c.CalcularMontoFinal());
        }

        public decimal CalcularGananciaMensual()
        {
            // Asumiendo que la ganancia es la recaudación menos los sueldos de las maestras
            decimal recaudacion = CalcularRecaudacionMensual();
            decimal sueldos = maestras.Sum(m => m.SueldoBruto);
            return recaudacion - sueldos;
        }

        public void ImprimirCuota(Alumno alumno)
        {
            Cuota cuota = cuotas.FirstOrDefault(c => c.Alumno == alumno && c.Pagada);
            if (cuota != null)
            {
                Console.WriteLine(cuota);
            }
        }
    }

}
