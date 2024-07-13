using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    public class HistoriaClinica
    {
        public DateTime Fecha { get; set; }
        public Especialidad Especialidad { get; set; }
        public List<OrdenMedica> OrdenesMedicas { get; set; }
        public List<string> Resultados { get; set; }

        public HistoriaClinica(DateTime pFecha, Especialidad pEspecialidad) 
        { 
          Fecha = pFecha;
          Especialidad = pEspecialidad;

          Resultados = new List<string>();
          OrdenesMedicas = new List<OrdenMedica>();
        }

        public void AgregarOrdenMedica(OrdenMedica orden)
        {
            OrdenesMedicas.Add(orden);
        }

        public void RegistrarResultado(string resultado)
        {
            Resultados.Add(resultado);
        }

        public decimal CalcularCosto()
        {
            decimal total = 0;
            foreach (var orden in OrdenesMedicas)
            {
                total += orden.Estudio.Costo;
            }
            return total;
        }

        public override string ToString() 
        {
            return $"{Fecha}, {Especialidad.Nombre} Costo Total: {CalcularCosto()}.";
        }
    }

}
