using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Jardin
    {
        public List<Sala> Salas { get; set; }
        public List<Maestra> Maestras { get; set; }
        public List<Alumno> Alumnos { get; set; }

        public Jardin() 
        { 
           Salas = new List<Sala>();
           Maestras = new List<Maestra>();
           Alumnos = new List<Alumno>();
        }

       public List<Alumno> OrdenarAlumnosPorApellido() 
        { 
           return Alumnos.OrderBy(a => a.Apellido).ToList();
        }
        public void AgregarSala(Sala sala)
        {
            Salas.Add(sala);
        }

        public void AgregarMaestra(Maestra maestra)
        {
            Maestras.Add(maestra);
        }

        

        public double CalcularRecaudacionMensual()
        {
            double totalRecaudado = 0;
            foreach (var sala in Salas)
            {
                foreach (var alumno in sala.Alumnos)
                {
                    totalRecaudado += alumno.Cuota; 
                }
            }
            return totalRecaudado;
        }

        public double CalcularGananciaMensual()
        {
            double totalRecaudado = CalcularRecaudacionMensual();
            double totalSueldos = Maestras.Sum(m => m.SueldoBruto);
            return totalRecaudado - totalSueldos;
        }

        
    }

}
