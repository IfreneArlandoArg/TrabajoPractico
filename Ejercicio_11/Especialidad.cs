using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    public class Especialidad
    {
        public string Nombre { get; set; }
        public List<Estudio> Estudios { get; set; }
        public decimal GananciaAcumulada { get; set; }
        public int CantidadPacientes { get; set; }

        public Especialidad(string pNombre) 
        { 
           Nombre = pNombre;
           Estudios = new List<Estudio>();

        }

        public void AgregarEstudio(Estudio estudio)
        {
            Estudios.Add(estudio);
            GananciaAcumulada += estudio.Costo;
        }

        public override string ToString()
        {
            return $"{Nombre}";
        }
    }

}
