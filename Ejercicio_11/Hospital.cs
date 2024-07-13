using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_11
{

    public class SistemaHospital
    {
        public List<Paciente> Pacientes { get; set; }
        public List<Medico> Medicos { get; set; } 
        public List<Especialidad> Especialidades { get; set; }

        public SistemaHospital() 
        { 
          Pacientes = new List<Paciente>();
          Medicos = new List<Medico>();
          Especialidades = new List<Especialidad>();
        }

        public List<Paciente> ObtenerPacientes() 
        { 
          return Pacientes;
        }
        public void AgregarPaciente(Paciente paciente)
        {
            Pacientes.Add(paciente);
        }

        public void AgregarMedico(Medico medico)
        {
            Medicos.Add(medico);
        }

        public void AgregarEspecialidad(Especialidad especialidad)
        {
            Especialidades.Add(especialidad);
        }

        public decimal CalcularGananciaTotal()
        {
            return Especialidades.Sum(e => e.GananciaAcumulada);
        }

        public List<Especialidad> ListarEspecialidadesPorGanancia()
        {
            return Especialidades.OrderBy(e => e.GananciaAcumulada).ToList();
        }

        public List<Especialidad> ListarEspecialidadesPorCantidadPacientes()
        {
            return Especialidades.OrderByDescending(e => e.CantidadPacientes).ToList();
        }
    }

}