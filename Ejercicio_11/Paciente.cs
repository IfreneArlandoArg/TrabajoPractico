using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    public class Paciente
    {
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public List<HistoriaClinica> HistoriasClinicas { get; set; }

        public Paciente(string pNombre, string pDNI, DateTime pFechaNacimiento, List<HistoriaClinica> pHistoriasClinicas) 
        { 
           Nombre = pNombre;
           DNI = pDNI;
           FechaNacimiento = pFechaNacimiento;
           HistoriasClinicas = pHistoriasClinicas;
        }

        public void AgregarHistoriaClinica(HistoriaClinica historia)
        {
            HistoriasClinicas.Add(historia);
        }

        public List<HistoriaClinica> ObtenerHistoriasOrdenadasPorFecha()
        {
            
            return HistoriasClinicas.OrderByDescending(h => h.Fecha).ToList();
             
        }

        public List<HistoriaClinica> FiltrarHistoriasPorEspecialidad()
        {
            return HistoriasClinicas.OrderBy(h => h.Especialidad.Nombre ).ToList();
        }

        public decimal CalcularCostoTotalTratamiento()
        {
            decimal total = 0;
            foreach (var historia in HistoriasClinicas)
            {
                total += historia.CalcularCosto();
            }
            return total;
        }

        public override string ToString()
        {
            return $"Nombre : {Nombre}, DNI: {DNI}";   
        }
    }

}
