using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
   
    public class Medico
    {
        public string Nombre { get; set; }
        public List<Especialidad> Especialidades { get; set; }
        public decimal CostoBase { get; set; }
        public List<Paciente> AgendaPacientes { get; set; } 

        public Medico(string pNombre, decimal pCostoBase) 
        { 
            Nombre = pNombre;
            CostoBase = pCostoBase;
            Especialidades = new List<Especialidad>();
            AgendaPacientes = new List<Paciente>();
        
        }

        public decimal CalcularCosto()
        {
            return CostoBase * (1 + 0.15m * Especialidades.Count);
        }

        public void AgregarPaciente(Paciente paciente)
        {
            AgendaPacientes.Add(paciente);
        }

        string JoinEspecialidades() 
        {
            string returnValue;
            if (Especialidades.Count == 0)
                returnValue = "Ninguno";

            List<string> strNombreEspecialidades = new List<string>();

            foreach (Especialidad especialidad in Especialidades) 
            {
                strNombreEspecialidades.Add(especialidad.ToString());
            }

            returnValue = string.Join(",", strNombreEspecialidades);

            return returnValue;
            
        }

        public override string ToString()
        {
            return $"{Nombre}, Especialidades: {JoinEspecialidades()}, Costo : {CalcularCosto()}";
        }
    }

}
